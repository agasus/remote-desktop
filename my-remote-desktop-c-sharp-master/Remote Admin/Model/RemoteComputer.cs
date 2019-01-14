using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Remote_Admin.Model
{
    public class RemoteComputer
    {
        public string ComputerUser { get; private set; }
        public string ClientIP { get; private set; }
        public string ComputerName { get; private set; }
        public Bitmap ComputerScreen { get; private set; }
        private Socket clientSocket;
        private AesCryptoServiceProvider AES;

        public delegate void RemoteComputerScreenDelegate();
        public delegate void RemoteComputerConnectionDelegate(RemoteComputer r);
        public event RemoteComputerScreenDelegate RemoteComputerScreenHasChangedEvent;
        public static event RemoteComputerConnectionDelegate RemoteComputerConnectionCloseEvent;

        public RemoteComputer(Socket _clientSocket)
        {
            clientSocket = _clientSocket;
            AES = new AesCryptoServiceProvider();
            AES.GenerateKey();
            AES.GenerateIV();

            byte[] data = new byte[1000];

            int lengthOfMessage = clientSocket.Receive(data);
            MessageEncrypt.EncryptAndSendAESKey(clientSocket, data, AES, lengthOfMessage);

            lengthOfMessage = clientSocket.Receive(data);
            ComputerName = CommandMessage.GetNameFromByte(data, lengthOfMessage);
            ComputerName = MessageEncrypt.AESDecrypt(ComputerName, AES);

            lengthOfMessage = clientSocket.Receive(data);
            ComputerUser = CommandMessage.GetNameFromByte(data, lengthOfMessage);
            ComputerUser = MessageEncrypt.AESDecrypt(ComputerUser, AES);

            lengthOfMessage = clientSocket.Receive(data);
            ClientIP = CommandMessage.GetNameFromByte(data, lengthOfMessage);
            ClientIP = MessageEncrypt.AESDecrypt(ClientIP, AES);

            Thread ReciveScreenImageThread = new Thread(ReciveScreenImage);
            ReciveScreenImageThread.IsBackground = true;
            ReciveScreenImageThread.Start(); //запускаем поток
        }

        private void ReciveScreenImage()
        {
            byte[] bytes = new byte[10000000];

            while (true)
            {
                try
                {
                    int bytesRec = clientSocket.Receive(bytes);

                    using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length))
                    {
                        ms.Write(bytes, 0, bytes.Length);
                        ms.Seek(0, SeekOrigin.Begin);
                        ComputerScreen = (Bitmap)Bitmap.FromStream(ms);
                    }
                    RemoteComputerScreenHasChangedEvent();
                }
                catch
                {
                    if (clientSocket.Connected == false)
                    {
                        clientSocket.Close();
                        RemoteComputerConnectionCloseEvent(this);
                        Thread.CurrentThread.Abort();
                    }
                     
                }
            }
        }

        public void Delete()
        {
            try
            {
                SendMessage(new CommandMessage(NetworkCommands.CLOSE_CONNECTION));
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            catch { }
        }

        public void SendMessage(CommandMessage m)
        {
            clientSocket.Send(MessageEncrypt.AESEncrypt(m.GetBytes(), AES));
        }

  

        private static int countOfListener = 6999; // для сокета... 
       
    }
}
