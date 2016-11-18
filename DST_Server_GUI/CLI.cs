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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.mStreamWriter.WriteLine(textBox_Send.Text.ToString());
        }

        public void Server_output_update()
        {
            if (Server_output.InvokeRequired) { 
                Server_output.BeginInvoke(new DataReceivedEventHandler(form1.SortOutputHandler), new[] { sendingProcess, outLine }); 
            }
        }
    }
}
