using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DST_Server_GUI
{
    public partial class CLI : Form
    {
        Form1 form1 = null;

        public CLI()
        {
            InitializeComponent();
        }

        public CLI(Form callingForm)
        {
            form1 = callingForm as Form1;
            InitializeComponent();
        }

        private void CLI_Load(object sender, EventArgs e)
        {
            Server_output.Text = form1.output.ToString();
            textBox_Send.KeyDown += OnKeyDownHandler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.mStreamWriter.WriteLine(textBox_Send.Text.ToString());
        }

        public TextBox Svr_output
        {
            get { return Server_output; }
            set { Server_output.Text = "";
                Server_output.Text }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            form1.mStreamWriter.WriteLine(textBox_Send.Text.ToString());
            textBox_Send.Text = "";
        }
        
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                form1.mStreamWriter.WriteLine(textBox_Send.Text.ToString());
                textBox_Send.Text = "";
            }
        }
    }
}
