using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DST_Server_GUI
{
    public partial class Setting : Form
    {
        Form1 form1 = null;
        public Setting()
        {
            InitializeComponent();
        }

        public Setting(Form callingForm)
        {
            form1 = callingForm as Form1;
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if (form1.ServerForSetting != "")
            {
                this.Text += "---" + form1.ServerForSetting;
                textBox_ServerName.Text = form1.ServerForSetting;
                textBox_ServerName.ReadOnly = true;
                LoadSetting();
            }
            else
            {
                this.Text += "---New Server";
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }

        private void label_ServerName_Click(object sender, EventArgs e)
        {
            textBox_ServerName.ReadOnly = false;
        }

        private void LoadSetting()
        {
            string ServerPath = form1.textBox_ServerPath.Text;
            StreamReader file = new StreamReader(ServerPath + 
                "\\" + form1.ServerForSetting + "\\cluster.ini");
            string cmd, data;
            while (file.Peek() >= 0)
            {
                cmd = file.ReadLine();
                
                switch (cmd)
                {
                    case "game_mode" :
                        break;
                    default:
                        break;
                }
            }
            
        }

        private string splitCmd(ref string cmd)
        {
            string data = "";
            bool data_flag = false;
            int data_index_first = 0, data_index_last = 0;
            for (data_index_first = 0; data_index_first < cmd.Length; data_index_first++)
            {
                
            }
            return data;
        }
                
    }
}
