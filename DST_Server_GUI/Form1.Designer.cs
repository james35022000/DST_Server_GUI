namespace DST_Server_GUI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Start = new System.Windows.Forms.Button();
            this.comboBox_server = new System.Windows.Forms.ComboBox();
            this.button_CLI = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.textBox_ServerPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Path = new System.Windows.Forms.Button();
            this.button_Setting = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dedicateServerPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Enabled = false;
            this.button_Start.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(344, 482);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(131, 62);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_server
            // 
            this.comboBox_server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_server.FormattingEnabled = true;
            this.comboBox_server.Location = new System.Drawing.Point(323, 168);
            this.comboBox_server.Name = "comboBox_server";
            this.comboBox_server.Size = new System.Drawing.Size(121, 22);
            this.comboBox_server.TabIndex = 1;
            this.comboBox_server.SelectedIndexChanged += new System.EventHandler(this.comboBox_server_SelectedIndexChanged);
            // 
            // button_CLI
            // 
            this.button_CLI.Enabled = false;
            this.button_CLI.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CLI.Location = new System.Drawing.Point(34, 168);
            this.button_CLI.Name = "button_CLI";
            this.button_CLI.Size = new System.Drawing.Size(69, 31);
            this.button_CLI.TabIndex = 5;
            this.button_CLI.Text = "CLI";
            this.button_CLI.UseVisualStyleBackColor = true;
            this.button_CLI.Click += new System.EventHandler(this.button_CLI_Click);
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(403, 85);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(75, 23);
            this.button_About.TabIndex = 6;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = true;
            // 
            // textBox_ServerPath
            // 
            this.textBox_ServerPath.Location = new System.Drawing.Point(34, 126);
            this.textBox_ServerPath.Name = "textBox_ServerPath";
            this.textBox_ServerPath.Size = new System.Drawing.Size(329, 22);
            this.textBox_ServerPath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "DST Server GUI V1.0";
            // 
            // button_Path
            // 
            this.button_Path.Location = new System.Drawing.Point(369, 126);
            this.button_Path.Name = "button_Path";
            this.button_Path.Size = new System.Drawing.Size(75, 23);
            this.button_Path.TabIndex = 9;
            this.button_Path.Text = "Path";
            this.button_Path.UseVisualStyleBackColor = true;
            this.button_Path.Click += new System.EventHandler(this.button_Path_Click);
            // 
            // button_Setting
            // 
            this.button_Setting.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Setting.Location = new System.Drawing.Point(369, 430);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(106, 46);
            this.button_Setting.TabIndex = 10;
            this.button_Setting.Text = "Setting";
            this.button_Setting.UseVisualStyleBackColor = true;
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(490, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel_Status
            // 
            this.statusLabel_Status.ForeColor = System.Drawing.Color.Red;
            this.statusLabel_Status.Name = "statusLabel_Status";
            this.statusLabel_Status.Size = new System.Drawing.Size(44, 20);
            this.statusLabel_Status.Text = "Stop";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dedicateServerPathToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 24);
            this.toolStripMenuItem1.Text = "Setting";
            // 
            // dedicateServerPathToolStripMenuItem
            // 
            this.dedicateServerPathToolStripMenuItem.Name = "dedicateServerPathToolStripMenuItem";
            this.dedicateServerPathToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.dedicateServerPathToolStripMenuItem.Text = "Dedicate Server Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 589);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_Setting);
            this.Controls.Add(this.button_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ServerPath);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_CLI);
            this.Controls.Add(this.comboBox_server);
            this.Controls.Add(this.button_Start);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DST Server GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.ComboBox comboBox_server;
        private System.Windows.Forms.Button button_CLI;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.TextBox textBox_ServerPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Path;
        private System.Windows.Forms.Button button_Setting;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_Status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dedicateServerPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

