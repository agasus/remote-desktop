namespace Remote_Admin
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.ClientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComputerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.remoteDesctopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Label6 = new MaterialSkin.Controls.MaterialLabel();
            this.Label7 = new MaterialSkin.Controls.MaterialLabel();
            this.CloseAllConnectionsButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TaskManagerButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ожидание соединения....";
            // 
            // listViewClients
            // 
            this.listViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientID,
            this.ComputerName,
            this.UserName,
            this.IP});
            this.listViewClients.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewClients.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.GridLines = true;
            this.listViewClients.Location = new System.Drawing.Point(7, 154);
            this.listViewClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewClients.MultiSelect = false;
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(394, 232);
            this.listViewClients.TabIndex = 12;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            // 
            // ClientID
            // 
            this.ClientID.Text = "ИД";
            this.ClientID.Width = 70;
            // 
            // ComputerName
            // 
            this.ComputerName.Text = "Имя компьютера";
            this.ComputerName.Width = 119;
            // 
            // UserName
            // 
            this.UserName.Text = "Пользователь";
            this.UserName.Width = 100;
            // 
            // IP
            // 
            this.IP.Text = "IP ";
            this.IP.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteDesctopToolStripMenuItem,
            this.sendFileToolStripMenuItem,
            this.runFileToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 92);
            // 
            // remoteDesctopToolStripMenuItem
            // 
            this.remoteDesctopToolStripMenuItem.Name = "remoteDesctopToolStripMenuItem";
            this.remoteDesctopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.remoteDesctopToolStripMenuItem.Text = "Remote Desktop";
            this.remoteDesctopToolStripMenuItem.Click += new System.EventHandler(this.remoteDesctopToolStripMenuItem_Click);
            // 
            // sendFileToolStripMenuItem
            // 
            this.sendFileToolStripMenuItem.Name = "sendFileToolStripMenuItem";
            this.sendFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sendFileToolStripMenuItem.Text = "Send file";
     
            // 
            // runFileToolStripMenuItem
            // 
            this.runFileToolStripMenuItem.Name = "runFileToolStripMenuItem";
            this.runFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.runFileToolStripMenuItem.Text = "Run file";
      
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "IP адрес: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 131);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(135, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "Имя компьютера:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Depth = 0;
            this.Label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label6.Location = new System.Drawing.Point(123, 103);
            this.Label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 19);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Label6";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Depth = 0;
            this.Label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label7.Location = new System.Drawing.Point(171, 131);
            this.Label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(108, 19);
            this.Label7.TabIndex = 23;
            this.Label7.Text = "materialLabel4";
            // 
            // CloseAllConnectionsButton
            // 
            this.CloseAllConnectionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseAllConnectionsButton.Depth = 0;
            this.CloseAllConnectionsButton.Location = new System.Drawing.Point(448, 339);
            this.CloseAllConnectionsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseAllConnectionsButton.Name = "CloseAllConnectionsButton";
            this.CloseAllConnectionsButton.Primary = true;
            this.CloseAllConnectionsButton.Size = new System.Drawing.Size(115, 39);
            this.CloseAllConnectionsButton.TabIndex = 28;
            this.CloseAllConnectionsButton.Text = "Закрыть все соединения";
            this.CloseAllConnectionsButton.UseVisualStyleBackColor = true;
            this.CloseAllConnectionsButton.Click += new System.EventHandler(this.closeAllConnectionsButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(7, 163);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(224, 1);
            this.materialDivider1.TabIndex = 29;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TaskManagerButton
            // 
            this.TaskManagerButton.Depth = 0;
            this.TaskManagerButton.Location = new System.Drawing.Point(448, 154);
            this.TaskManagerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.TaskManagerButton.Name = "TaskManagerButton";
            this.TaskManagerButton.Primary = true;
            this.TaskManagerButton.Size = new System.Drawing.Size(115, 37);
            this.TaskManagerButton.TabIndex = 30;
            this.TaskManagerButton.Text = "Диспетчер задач";
            this.TaskManagerButton.UseVisualStyleBackColor = true;
            this.TaskManagerButton.Click += new System.EventHandler(this.TaskManagerButton_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 390);
            this.Controls.Add(this.TaskManagerButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.CloseAllConnectionsButton);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewClients);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(627, 390);
            this.Name = "ServerForm";
            this.Sizable = false;
            this.Text = "Система удалённого доступа | сервер";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader ClientID;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader ComputerName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel Label6;
        private MaterialSkin.Controls.MaterialLabel Label7;
        private MaterialSkin.Controls.MaterialRaisedButton CloseAllConnectionsButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteDesctopToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem runFileToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton TaskManagerButton;
    }
}