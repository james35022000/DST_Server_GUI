namespace DST_Server_GUI
{
    partial class Setting
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
            this.tabControl_Mod = new System.Windows.Forms.TabControl();
            this.tabPage_Server = new System.Windows.Forms.TabPage();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_PauseWhenEmpty = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_Intention = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_GameMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_PVP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MaxPlayer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ServerPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CavesPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MasterPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ServerDscpt = new System.Windows.Forms.TextBox();
            this.label_ServerName = new System.Windows.Forms.Label();
            this.textBox_ServerName = new System.Windows.Forms.TextBox();
            this.tabPage_Map = new System.Windows.Forms.TabPage();
            this.tabPage_Mod = new System.Windows.Forms.TabPage();
            this.tabControl_Mod.SuspendLayout();
            this.tabPage_Server.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Mod
            // 
            this.tabControl_Mod.Controls.Add(this.tabPage_Server);
            this.tabControl_Mod.Controls.Add(this.tabPage_Map);
            this.tabControl_Mod.Controls.Add(this.tabPage_Mod);
            this.tabControl_Mod.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Mod.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Mod.Name = "tabControl_Mod";
            this.tabControl_Mod.SelectedIndex = 0;
            this.tabControl_Mod.Size = new System.Drawing.Size(468, 481);
            this.tabControl_Mod.TabIndex = 0;
            // 
            // tabPage_Server
            // 
            this.tabPage_Server.Controls.Add(this.button_Save);
            this.tabPage_Server.Controls.Add(this.comboBox_PauseWhenEmpty);
            this.tabPage_Server.Controls.Add(this.label11);
            this.tabPage_Server.Controls.Add(this.comboBox_Intention);
            this.tabPage_Server.Controls.Add(this.label10);
            this.tabPage_Server.Controls.Add(this.label9);
            this.tabPage_Server.Controls.Add(this.comboBox_GameMode);
            this.tabPage_Server.Controls.Add(this.label8);
            this.tabPage_Server.Controls.Add(this.comboBox_PVP);
            this.tabPage_Server.Controls.Add(this.label7);
            this.tabPage_Server.Controls.Add(this.textBox_MaxPlayer);
            this.tabPage_Server.Controls.Add(this.label6);
            this.tabPage_Server.Controls.Add(this.label5);
            this.tabPage_Server.Controls.Add(this.textBox_ServerPwd);
            this.tabPage_Server.Controls.Add(this.label4);
            this.tabPage_Server.Controls.Add(this.textBox_CavesPort);
            this.tabPage_Server.Controls.Add(this.label3);
            this.tabPage_Server.Controls.Add(this.textBox_MasterPort);
            this.tabPage_Server.Controls.Add(this.label2);
            this.tabPage_Server.Controls.Add(this.textBox_ServerDscpt);
            this.tabPage_Server.Controls.Add(this.label_ServerName);
            this.tabPage_Server.Controls.Add(this.textBox_ServerName);
            this.tabPage_Server.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Server.Name = "tabPage_Server";
            this.tabPage_Server.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Server.Size = new System.Drawing.Size(460, 454);
            this.tabPage_Server.TabIndex = 0;
            this.tabPage_Server.Text = "Server";
            this.tabPage_Server.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(336, 411);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(118, 37);
            this.button_Save.TabIndex = 23;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_PauseWhenEmpty
            // 
            this.comboBox_PauseWhenEmpty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PauseWhenEmpty.FormattingEnabled = true;
            this.comboBox_PauseWhenEmpty.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox_PauseWhenEmpty.Location = new System.Drawing.Point(193, 303);
            this.comboBox_PauseWhenEmpty.Name = "comboBox_PauseWhenEmpty";
            this.comboBox_PauseWhenEmpty.Size = new System.Drawing.Size(64, 22);
            this.comboBox_PauseWhenEmpty.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Pause when empty";
            // 
            // comboBox_Intention
            // 
            this.comboBox_Intention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Intention.FormattingEnabled = true;
            this.comboBox_Intention.Items.AddRange(new object[] {
            "cooperative",
            "social",
            "competitive",
            "madness"});
            this.comboBox_Intention.Location = new System.Drawing.Point(193, 173);
            this.comboBox_Intention.Name = "comboBox_Intention";
            this.comboBox_Intention.Size = new System.Drawing.Size(121, 22);
            this.comboBox_Intention.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Intention";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(28, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(400, 2);
            this.label9.TabIndex = 18;
            // 
            // comboBox_GameMode
            // 
            this.comboBox_GameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GameMode.FormattingEnabled = true;
            this.comboBox_GameMode.Items.AddRange(new object[] {
            "Endless",
            "Survival",
            "Wilderness"});
            this.comboBox_GameMode.Location = new System.Drawing.Point(193, 273);
            this.comboBox_GameMode.Name = "comboBox_GameMode";
            this.comboBox_GameMode.Size = new System.Drawing.Size(121, 22);
            this.comboBox_GameMode.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Game Mode";
            // 
            // comboBox_PVP
            // 
            this.comboBox_PVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PVP.FormattingEnabled = true;
            this.comboBox_PVP.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox_PVP.Location = new System.Drawing.Point(193, 333);
            this.comboBox_PVP.Name = "comboBox_PVP";
            this.comboBox_PVP.Size = new System.Drawing.Size(64, 22);
            this.comboBox_PVP.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "PVP";
            // 
            // textBox_MaxPlayer
            // 
            this.textBox_MaxPlayer.Location = new System.Drawing.Point(193, 243);
            this.textBox_MaxPlayer.Name = "textBox_MaxPlayer";
            this.textBox_MaxPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_MaxPlayer.Size = new System.Drawing.Size(36, 22);
            this.textBox_MaxPlayer.TabIndex = 13;
            this.textBox_MaxPlayer.Text = "6";
            this.textBox_MaxPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Max Player(1-64)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server Passward";
            // 
            // textBox_ServerPwd
            // 
            this.textBox_ServerPwd.Location = new System.Drawing.Point(193, 53);
            this.textBox_ServerPwd.Name = "textBox_ServerPwd";
            this.textBox_ServerPwd.Size = new System.Drawing.Size(235, 22);
            this.textBox_ServerPwd.TabIndex = 9;
            this.textBox_ServerPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Caves Port";
            // 
            // textBox_CavesPort
            // 
            this.textBox_CavesPort.Location = new System.Drawing.Point(193, 143);
            this.textBox_CavesPort.Name = "textBox_CavesPort";
            this.textBox_CavesPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_CavesPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_CavesPort.TabIndex = 7;
            this.textBox_CavesPort.Text = "11001";
            this.textBox_CavesPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Master Port";
            // 
            // textBox_MasterPort
            // 
            this.textBox_MasterPort.Location = new System.Drawing.Point(193, 113);
            this.textBox_MasterPort.Name = "textBox_MasterPort";
            this.textBox_MasterPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_MasterPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_MasterPort.TabIndex = 5;
            this.textBox_MasterPort.Text = "10999";
            this.textBox_MasterPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Description";
            // 
            // textBox_ServerDscpt
            // 
            this.textBox_ServerDscpt.Location = new System.Drawing.Point(193, 83);
            this.textBox_ServerDscpt.Name = "textBox_ServerDscpt";
            this.textBox_ServerDscpt.Size = new System.Drawing.Size(235, 22);
            this.textBox_ServerDscpt.TabIndex = 3;
            this.textBox_ServerDscpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ServerName
            // 
            this.label_ServerName.AutoSize = true;
            this.label_ServerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ServerName.Location = new System.Drawing.Point(32, 23);
            this.label_ServerName.Name = "label_ServerName";
            this.label_ServerName.Size = new System.Drawing.Size(84, 14);
            this.label_ServerName.TabIndex = 2;
            this.label_ServerName.Text = "Server Name";
            this.label_ServerName.Click += new System.EventHandler(this.label_ServerName_Click);
            // 
            // textBox_ServerName
            // 
            this.textBox_ServerName.Location = new System.Drawing.Point(193, 23);
            this.textBox_ServerName.Name = "textBox_ServerName";
            this.textBox_ServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ServerName.Size = new System.Drawing.Size(235, 22);
            this.textBox_ServerName.TabIndex = 1;
            this.textBox_ServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_Map
            // 
            this.tabPage_Map.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Map.Name = "tabPage_Map";
            this.tabPage_Map.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Map.Size = new System.Drawing.Size(460, 454);
            this.tabPage_Map.TabIndex = 1;
            this.tabPage_Map.Text = "Map";
            this.tabPage_Map.UseVisualStyleBackColor = true;
            // 
            // tabPage_Mod
            // 
            this.tabPage_Mod.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Mod.Name = "tabPage_Mod";
            this.tabPage_Mod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mod.Size = new System.Drawing.Size(460, 454);
            this.tabPage_Mod.TabIndex = 2;
            this.tabPage_Mod.Text = "Mod";
            this.tabPage_Mod.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 505);
            this.Controls.Add(this.tabControl_Mod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.ShowInTaskbar = false;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.tabControl_Mod.ResumeLayout(false);
            this.tabPage_Server.ResumeLayout(false);
            this.tabPage_Server.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Mod;
        private System.Windows.Forms.TabPage tabPage_Server;
        private System.Windows.Forms.TabPage tabPage_Map;
        private System.Windows.Forms.Label label_ServerName;
        private System.Windows.Forms.TextBox textBox_ServerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ServerPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CavesPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MasterPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ServerDscpt;
        private System.Windows.Forms.ComboBox comboBox_PVP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MaxPlayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Intention;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_PauseWhenEmpty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_GameMode;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TabPage tabPage_Mod;

    }
}