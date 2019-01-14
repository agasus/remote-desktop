using System;
using System.Net;
using System.Windows.Forms;
using Remote_Admin.Model;
using MaterialSkin.Controls;
using MaterialSkin;
using Remote_Admin.View;

namespace Remote_Admin
{
    public partial class ServerForm : MaterialForm
    {
        private Server server;

        public ServerForm()
        {
            InitializeComponent();

            server = new Server();
            server.RemoteComputersListChangedEvent += UpdateRemoteComputers;


            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Amber900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green300, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            Label7.Text = Environment.MachineName;
            Label6.Text = Dns.GetHostByName(Environment.MachineName).AddressList[0].ToString();
        }

        private void UpdateRemoteComputers()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    listViewClients.Items.Clear();
                    for (int i = 0; i < server.RemoteComputers.Count; i++)
                    {
                        listViewClients.Items.Add(new ListViewItem(new string[] { i.ToString(), server.RemoteComputers[i].ComputerName, server.RemoteComputers[i].ComputerUser, server.RemoteComputers[i].ClientIP }));
                    }

                }));
        }


        private void closeAllConnectionsButton_Click(object sender, EventArgs e)
        {
            server.CloseAllConnections();
        }

        private void remoteDesctopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isListViewSelectedItems())
            {
                var rdf = new RemoteDesktopForm(server.RemoteComputers[listViewClients.Items.IndexOf(listViewClients.SelectedItems[0])]);
                this.Hide();
                rdf.ShowDialog();
                this.Show();
            }
        }



        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isListViewSelectedItems())
                server.RemoteComputerConnectionClose(listViewClients.FocusedItem.Index);
        }


    

        



        private void TaskManagerButton_Click(object sender, EventArgs e)
        {
            if (isListViewSelectedItems())
            {
                var tmf = new TaskManagerForm(server.RemoteComputers[listViewClients.Items.IndexOf(listViewClients.SelectedItems[0])]);
                tmf.ShowDialog();
            }

        }

        private void Server_FormClosing(Object sender, FormClosingEventArgs e)
        {
            server.CloseAllConnectionsAndExit();
        }

        private bool isListViewSelectedItems()
        {
            if (listViewClients.SelectedItems.Count < 1)
            {
                MessageBox.Show("You have to select a client in order to access this function!",
                   "ERROR : Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
