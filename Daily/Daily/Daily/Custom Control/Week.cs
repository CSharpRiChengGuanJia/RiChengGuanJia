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
    public partial class Week : UserControl
    {
        public String anyText
        {
            get { return labelWeek.Text; }
            set { labelWeek.Text = value; }
        }
        public Week()
        {
            InitializeComponent();
        }
    }
}
