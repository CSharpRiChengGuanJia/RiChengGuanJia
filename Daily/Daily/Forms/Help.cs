using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily.Forms
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
