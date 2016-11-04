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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_server = new System.Windows.Forms.ComboBox();
            this.Server_output = new System.Windows.Forms.TextBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_server
            // 
            this.comboBox_server.FormattingEnabled = true;
            this.comboBox_server.Location = new System.Drawing.Point(467, 120);
            this.comboBox_server.Name = "comboBox_server";
            this.comboBox_server.Size = new System.Drawing.Size(121, 22);
            this.comboBox_server.TabIndex = 1;
            this.comboBox_server.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Server_output
            // 
            this.Server_output.Location = new System.Drawing.Point(24, 87);
            this.Server_output.Multiline = true;
            this.Server_output.Name = "Server_output";
            this.Server_output.ReadOnly = true;
            this.Server_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Server_output.Size = new System.Drawing.Size(435, 406);
            this.Server_output.TabIndex = 2;
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(24, 520);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(435, 22);
            this.textBox_Send.TabIndex = 3;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(488, 519);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 4;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 559);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Send);
            this.Controls.Add(this.Server_output);
            this.Controls.Add(this.comboBox_server);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "DST Server GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_server;
        private System.Windows.Forms.TextBox Server_output;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button button_Send;
    }
}

