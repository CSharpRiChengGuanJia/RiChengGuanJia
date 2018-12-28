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
    public partial class TaskViewPage : UserControl
    {
        public TaskViewPage()
        {
            InitializeComponent();
        }

        private void buttonDay_Click(object sender, EventArgs e)
        {
            buttonDay.FlatAppearance.BorderSize = 1;
            buttonWeek.FlatAppearance.BorderSize = 0;
            buttonAll.FlatAppearance.BorderSize = 0;
            PanelTasks.Controls.Clear();
            //这里加display,下同
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            buttonDay.FlatAppearance.BorderSize = 0;
            buttonAll.FlatAppearance.BorderSize = 1;
            buttonWeek.FlatAppearance.BorderSize = 0;
            PanelTasks.Controls.Clear();
        }

        private void buttonWeek_Click(object sender, EventArgs e)
        {
            buttonDay.FlatAppearance.BorderSize = 0;
            buttonAll.FlatAppearance.BorderSize = 0;
            buttonWeek.FlatAppearance.BorderSize = 1;
            PanelTasks.Controls.Clear();
        }
    }
}
