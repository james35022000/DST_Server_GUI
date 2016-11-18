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
        private Form1 form1 = null;
        public Boolean Master;

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
            Master = true;
            button_CLIMode.Text = "Master";
            Server_output.Text = form1.Master_output.ToString();
            textBox_Send.KeyDown += OnKeyDownHandler;
        }
        
        public TextBox Svr_output
        {
            get { return Server_output; }
            set { Server_output.Text = value.ToString(); }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (Master)
            {
                form1.MasterStreamWriter.WriteLine(textBox_Send.Text.ToString());
                textBox_Send.Text = "";
            }
            else
            {
                form1.CavesStreamWriter.WriteLine(textBox_Send.Text.ToString());
                textBox_Send.Text = "";
            }
        }
        
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Master)
                {
                    form1.MasterStreamWriter.WriteLine(textBox_Send.Text.ToString());
                    textBox_Send.Text = "";
                }
                else
                {
                    form1.CavesStreamWriter.WriteLine(textBox_Send.Text.ToString());
                    textBox_Send.Text = "";
                }
            }
        }

        private void Server_output_TextChanged(object sender, EventArgs e)
        {
            Server_output.SelectionStart = Server_output.Text.Length;
            Server_output.ScrollToCaret();

        }

        private void button_CLIMode_Click(object sender, EventArgs e)
        {
            if (Master)
            {
                button_CLIMode.Text = "Caves";
                Server_output.Text = form1.Caves_output.ToString();
                Master = false;
            }
            else
            {
                button_CLIMode.Text = "Master";
                Server_output.Text = form1.Master_output.ToString();
                Master = true;
            }
        }
    }
}
