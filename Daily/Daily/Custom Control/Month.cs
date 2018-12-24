using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily.Custom_Control
{
    public partial class Month : UserControl
    {
        public string anyText
        {
            get
            {
                return label.Text;
            }
            set
            {
                label.Text = value;

            }
        }
        public Month()
        {
            InitializeComponent();
            label.BackColor = Color.FromArgb(0, 50, 50, 50);
        }

        private void label_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
