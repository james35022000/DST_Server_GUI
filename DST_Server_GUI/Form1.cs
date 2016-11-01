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
            Process Server_Master = new Process();
            //info.FileName = "dontstarve_dedicated_server_nullrenderer";
            //info.WorkingDirectory = @"E:\Steam\steamapps\common\Don't Starve Together\bin";
            //info.Arguments = "-console -cluster DST_Server -shard Master";
            Server_Master.StartInfo.FileName = "cmd.exe";
            Server_Master.StartInfo.CreateNoWindow = true;
            Server_Master.StartInfo.UseShellExecute = false;
            Server_Master.StartInfo.RedirectStandardOutput = true;
            Server_Master.StartInfo.RedirectStandardError = true;
            Server_Master.StartInfo.RedirectStandardInput = true;

            Server_Master.OutputDataReceived += new DataReceivedEventHandler((object sendingProcess, DataReceivedEventArgs outLine) =>
            {
                if (!String.IsNullOrEmpty(outLine.Data)) {
                    output.Append(Environment.NewLine + outLine.Data);
                }
            });

            Server_Master.Start();

            mStreamWriter = Server_Master.StandardInput;
            Server_Master.BeginOutputReadLine();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
