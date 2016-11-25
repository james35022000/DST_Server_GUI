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
                if (!Directory.Exists(@form1.textBox_ServerPath.Text + "\\" +
                        form1.ServerForSetting))
                {
                    MessageBox.Show("Directory not found! Create new Server", "Error");
                    this.Text += "---New Server";
                }
                else
                {
                    this.Text += "---" + form1.ServerForSetting;
                    textBox_ServerName.Text = form1.ServerForSetting;
                    textBox_ServerName.ReadOnly = true;
                    LoadSetting();
                }
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
            /*-----------------------cluster setting---------------------------*/
            StreamReader file = new StreamReader(ServerPath + 
                "\\" + form1.ServerForSetting + "\\cluster.ini");
            string cmd, data;
            while (file.Peek() >= 0)
            {
                cmd = file.ReadLine();
                data = splitCmd(ref cmd);
                switch (cmd)
                {
                    case "game_mode":
                        if (data == "endless")
                            comboBox_GameMode.SelectedIndex = 0;
                        else if (data == "survival")
                            comboBox_GameMode.SelectedIndex = 1;
                        else if (data == "wilderness")
                            comboBox_GameMode.SelectedIndex = 2;
                        break;
                    case "max_players":
                        if (Convert.ToInt32(data) <= 64 && Convert.ToInt32(data) >= 1)
                            textBox_MaxPlayer.Text = data;
                        break;
                    case "pvp":
                        if (data == "true")
                            comboBox_PVP.SelectedIndex = 0;
                        else if (data == "false")
                            comboBox_PVP.SelectedIndex = 1;
                        break;
                    case "pause_when_empty":
                        if (data == "true")
                            comboBox_PauseWhenEmpty.SelectedIndex = 0;
                        else if (data == "false")
                            comboBox_PauseWhenEmpty.SelectedIndex = 1;
                        break;
                    case "cluster_description":
                        textBox_ServerDscpt.Text = data;
                        break;
                    case "cluster_name":
                        if (data == "") break;
                        textBox_ServerName.Text = data;
                        break;
                    case "cluster_intention":
                        if (data == "cooperative")
                            comboBox_Intention.SelectedIndex = 0;
                        else if (data == "social")
                            comboBox_Intention.SelectedIndex = 1;
                        else if (data == "competitive")
                            comboBox_Intention.SelectedIndex = 2;
                        else if (data == "madness")
                            comboBox_Intention.SelectedIndex = 3;
                        break;
                    case "cluster_password":
                        textBox_ServerPwd.Text = data;
                        break;
                    default:
                        break;
                }
            }
            file.Close();
            /*-----------------------Master setting---------------------------*/
            if (Directory.Exists(@ServerPath + "\\" + form1.ServerForSetting +
                "\\Master"))
            {
                file = new StreamReader(ServerPath +
                    "\\" + form1.ServerForSetting + "\\Master\\server.ini");
                while (file.Peek() >= 0)
                {
                    cmd = file.ReadLine();
                    data = splitCmd(ref cmd);
                    switch (cmd)
                    {
                        case "server_port":
                            textBox_MasterPort.Text = data;
                            break;
                        default:
                            break;
                    }
                }
                file.Close();
            }
            /*------------------------Caves setting---------------------------*/
            if (!Directory.Exists(@ServerPath + "\\" + form1.ServerForSetting +
                "\\Caves"))
                return;
            file = new StreamReader(ServerPath +
                    "\\" + form1.ServerForSetting + "\\Caves\\server.ini");
            cmd = file.ReadLine();
            data = splitCmd(ref cmd);
            switch (cmd)
            {
                case "server_port":
                    textBox_CavesPort.Text = data;
                    break;
                default:
                    break;
            }
            file.Close();
        }

        private string splitCmd(ref string cmd)
        {
            string data = "";
            bool data_flag = false;
            int cmd_index_first = 0, cmd_index_last = 0;
            int data_index_first = 0, data_index_last = 0;
            for (int i = 0; i < cmd.Length; i++)
            {
                if (data_flag)
                {
                    for (; i < cmd.Length; i++)
                        if (cmd[i] != ' ')
                            data_index_last = i + 1;
                }
                else
                {
                    if (cmd[i] == '=')
                    {
                        data_flag = true;
                        for (i = i + 1; i < cmd.Length; i++)
                            if (cmd[i] != ' ')
                                break;
                        data_index_first = i;
                        data_index_last = i + 1;
                    }
                    else if (cmd[i] != ' ')
                        cmd_index_last = i + 1;
                }
            }
            if((data_index_first != 0) && (data_index_first != data_index_last))
                data = cmd.Substring(data_index_first, data_index_last - data_index_first);
            cmd = cmd.Substring(cmd_index_first, cmd_index_last - cmd_index_first);
            return data;
        }

        private bool nameEqual(string name)
        {
            return false;
        }
                
    }
}
