using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily
{
    public partial class Detail : UserControl
    {
        public override string Text { get { return label1.Text; } set { label1.Text = value; } }
        public Detail()
        {
            InitializeComponent();
        }
    }
}
