namespace DST_Server_GUI
{
    partial class CLI
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
            this.Server_output = new System.Windows.Forms.TextBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_CLIMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server_output
            // 
            this.Server_output.Location = new System.Drawing.Point(29, 43);
            this.Server_output.Multiline = true;
            this.Server_output.Name = "Server_output";
            this.Server_output.ReadOnly = true;
            this.Server_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Server_output.Size = new System.Drawing.Size(418, 235);
            this.Server_output.TabIndex = 3;
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(29, 306);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(343, 22);
            this.textBox_Send.TabIndex = 4;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(387, 304);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 5;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            // 
            // button_CLIMode
            // 
            this.button_CLIMode.Location = new System.Drawing.Point(197, 14);
            this.button_CLIMode.Name = "button_CLIMode";
            this.button_CLIMode.Size = new System.Drawing.Size(75, 23);
            this.button_CLIMode.TabIndex = 6;
            this.button_CLIMode.Text = "Master";
            this.button_CLIMode.UseVisualStyleBackColor = true;
            // 
            // CLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 340);
            this.Controls.Add(this.button_CLIMode);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Send);
            this.Controls.Add(this.Server_output);
            this.Name = "CLI";
            this.Text = "CLI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Server_output;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_CLIMode;
    }
}