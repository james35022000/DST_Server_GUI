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
    public partial class Form1 : Form
    {
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
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "dontstarve_dedicated_server_nullrenderer.exe";
            info.WorkingDirectory = "C:\\\"Program Files (x86)\"\\Steam\\steamapps\\common\\\"Don't Starve Together Dedicated Server\"\\bin";
            Process.Start(info);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
