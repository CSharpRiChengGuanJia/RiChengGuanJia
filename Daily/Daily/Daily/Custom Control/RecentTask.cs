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
    public partial class RecentTask : UserControl
    {
        public RecentTask()
        {
            InitializeComponent();
            labelTask.BackColor = Color.FromArgb(0, Color.Black);
            labelTime.BackColor = Color.FromArgb(0, Color.Black);
        }
    }
}
