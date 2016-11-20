using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            this.Text += "---New Server";
        }

    }
}
