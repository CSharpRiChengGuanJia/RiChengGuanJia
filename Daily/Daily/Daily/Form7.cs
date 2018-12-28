using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily
{
    public partial class Form7 : Form
    {
        Form1 f1;
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(Form1 f1) : this()
        {
            this.f1 = f1;
            dateTimePicker1.Value = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}
