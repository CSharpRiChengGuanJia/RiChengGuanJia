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
    public partial class Day : UserControl
    {
        public override string Text { get { return label.Text; } set { label.Text = value; } }
        public Day()
        {
            InitializeComponent();
            label.BackColor = Color.FromArgb(0, Color.Black);
            this.BackColor = Color.FromArgb(60, Color.Black);
        }
    }
}
