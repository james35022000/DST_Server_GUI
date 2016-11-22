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
            string setting;
            while (file.Peek() >= 0)
            {
                //setting = file.R
                
                switch (setting)
                {
                    
                }
            }
            
        }
                
    }
}
