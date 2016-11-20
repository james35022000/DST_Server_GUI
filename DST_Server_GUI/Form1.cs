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
    public partial class Form1 : Form
    {
        public StreamWriter MasterStreamWriter, CavesStreamWriter;
        public StringBuilder Master_output = new StringBuilder(""), Caves_output = new StringBuilder("");
        private CLI cli = null;
        private Setting setting = null;
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        Process Server_Master, Server_Caves;
        int Master_line_cnt = 0, Caves_line_cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            string AppPath = Application.StartupPath + "\\data";
            try 
            {
                string[] data = System.IO.File.ReadAllLines(AppPath);
                if(data[0] != null) {
                    int num = Convert.ToInt32(data[0].Split(',')[1]);
                    for (int i = 1; i <= num; i++)
                        comboBox_server.Items.Add(data[i]);
                }
            }
            catch (FileNotFoundException ex)
            {
                File.Create(AppPath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*---------------------------------Master---------------------------------------*/
            try { Process.GetProcessById(Server_Master.Id); }
            catch  /* If process doesn't exist, create new process. */
            {
                Server_Master = new Process();
                Server_Caves = new Process();
                //info.FileName = "dontstarve_dedicated_server_nullrenderer";
                //info.WorkingDirectory = @"E:\Steam\steamapps\common\Don't Starve Together\bin";
                //info.Arguments = "-console -cluster DST_Server -shard Master";
                Server_Master.StartInfo.FileName = "cmd.exe";
                Server_Master.StartInfo.CreateNoWindow = true;
                Server_Master.StartInfo.UseShellExecute = false;
                Server_Master.StartInfo.RedirectStandardOutput = true;
                Server_Master.StartInfo.RedirectStandardError = true;
                Server_Master.StartInfo.RedirectStandardInput = true;

                Server_Master.OutputDataReceived += new DataReceivedEventHandler(MasterSortOutputHandler);

                Server_Master.Start();

                MasterStreamWriter = Server_Master.StandardInput;
                Master_line_cnt = 0;
                Server_Master.BeginOutputReadLine();

                statusLabel_Status.Text = "Waiting...";
            }
            /*---------------------------------Caves---------------------------------------*/
            try { Process.GetProcessById(Server_Caves.Id); }
            catch 
            {
                Server_Caves.StartInfo.FileName = "cmd.exe";
                Server_Caves.StartInfo.CreateNoWindow = true;
                Server_Caves.StartInfo.UseShellExecute = false;
                Server_Caves.StartInfo.RedirectStandardOutput = true;
                Server_Caves.StartInfo.RedirectStandardError = true;
                Server_Caves.StartInfo.RedirectStandardInput = true;

                Server_Caves.OutputDataReceived += new DataReceivedEventHandler(CavesSortOutputHandler);

                Server_Caves.Start();

                CavesStreamWriter = Server_Caves.StandardInput;
                Caves_line_cnt = 0;
                Server_Caves.BeginOutputReadLine();

                statusLabel_Status.Text = "Waiting...";
            }
        }

        public void MasterSortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (cli != null)
            {
                if (cli.Svr_output.InvokeRequired) { cli.Svr_output.BeginInvoke(new DataReceivedEventHandler(MasterSortOutputHandler), new[] { sendingProcess, outLine }); }
                else
                {
                    if (!String.IsNullOrEmpty(outLine.Data))
                    {
                        while (Master_line_cnt >= 30)
                        {
                            Master_output.Remove(0, Master_output.ToString().IndexOf("\n") + 1);
                            Master_line_cnt--;
                        }
                        Master_output.Append(outLine.Data + Environment.NewLine);
                        Master_line_cnt++;
                        cli.Svr_output.Text = Master_output.ToString();
                    }
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(outLine.Data))
                {
                    while (Master_line_cnt >= 30)
                    {
                        Master_output.Remove(0, Master_output.ToString().IndexOf("\n") + 1);
                        Master_line_cnt--;
                    }
                    Master_output.Append(outLine.Data + Environment.NewLine);
                    Master_line_cnt++;
                }
            }
        }

        public void CavesSortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (cli != null)
            {
                if (cli.Svr_output.InvokeRequired) { cli.Svr_output.BeginInvoke(new DataReceivedEventHandler(CavesSortOutputHandler), new[] { sendingProcess, outLine }); }
                else
                {
                    if (!String.IsNullOrEmpty(outLine.Data))
                    {
                        while (Caves_line_cnt >= 30)
                        {
                            Caves_output.Remove(0, Caves_output.ToString().IndexOf("\n") + 1);
                            Caves_line_cnt--;
                        }
                        Caves_output.Append(outLine.Data + Environment.NewLine);
                        Caves_line_cnt++;
                        cli.Svr_output.Text = Caves_output.ToString();
                    }
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(outLine.Data))
                {
                    while (Caves_line_cnt >= 30)
                    {
                        Caves_output.Remove(0, Caves_output.ToString().IndexOf("\n") + 1);
                        Caves_line_cnt--;
                    }
                    Caves_output.Append(outLine.Data + Environment.NewLine);
                    Caves_line_cnt++;
                }
            }
        }


        private void button_CLI_Click(object sender, EventArgs e)
        {
            cli = new CLI(this);
            cli.FormClosed += CLI_Form_Closed;
            cli.Show();
        }

        private void button_Path_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBox_ServerPath.Text = folderBrowserDialog.SelectedPath;
        }

        private void button_Setting_Click(object sender, EventArgs e)
        {
            setting = new Setting(this);
            setting.FormClosed += Setting_Form_Closed;
            setting.Show();
        }

        private void CLI_Form_Closed(object sender, FormClosedEventArgs e)
        {
            cli = null;
        }

        private void Setting_Form_Closed(object sender, FormClosedEventArgs e)
        {
            setting = null;
        }

        private void textBox_ServerPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
            }
        }

    }
}
