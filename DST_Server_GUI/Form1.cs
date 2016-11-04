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
        private StreamWriter mStreamWriter;
        private StringBuilder output = new StringBuilder("");
        Process Server_Master;
        int line_cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_server.Items.AddRange(new Object[] { "DST_Server1", "DST_Server2" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { Process.GetProcessById(Server_Master.Id); }
            catch  /* If process doesn't exist, create new process. */
            {
                Server_Master = new Process();
                //info.FileName = "dontstarve_dedicated_server_nullrenderer";
                //info.WorkingDirectory = @"E:\Steam\steamapps\common\Don't Starve Together\bin";
                //info.Arguments = "-console -cluster DST_Server -shard Master";
                Server_Master.StartInfo.FileName = "cmd.exe";
                Server_Master.StartInfo.CreateNoWindow = true;
                Server_Master.StartInfo.UseShellExecute = false;
                Server_Master.StartInfo.RedirectStandardOutput = true;
                Server_Master.StartInfo.RedirectStandardError = true;
                Server_Master.StartInfo.RedirectStandardInput = true;

                Server_Master.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);

                Server_Master.Start();

                mStreamWriter = Server_Master.StandardInput;
                line_cnt = 0;
                Server_Master.BeginOutputReadLine();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (Server_output.InvokeRequired) { Server_output.BeginInvoke(new DataReceivedEventHandler(SortOutputHandler), new[] { sendingProcess, outLine }); }
            else {
                if (!String.IsNullOrEmpty(outLine.Data))  {
                    while (line_cnt >= 30) {
                        output.Remove(0, output.ToString().IndexOf("\n") + 1);
                        line_cnt--;
                    }
                    output.Append(outLine.Data + Environment.NewLine);
                    line_cnt++;
                    Server_output.Text = output.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mStreamWriter.WriteLine(textBox_Send.Text.ToString());
        }
    }
}
