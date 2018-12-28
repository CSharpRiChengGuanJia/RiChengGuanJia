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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        bool Checked = true;
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AlarmCheck_Click(object sender, EventArgs e)
        {
           AlarmCheck.Image = Image.FromFile(@"..\..\Resources\Unchecked.png");
            Checked = false;
        }
    }
}
