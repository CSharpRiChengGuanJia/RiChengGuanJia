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
    public partial class Form5 : Form
    {
        Form1 f1;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Form1 f1) : this()
        {
            this.f1 = f1;
            dateTimePicker1.Value = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            dateTimePicker2.Value = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string workname = textBox1.Text;
            DateTime starttime = dateTimePicker1.Value;
            DateTime endtime = dateTimePicker2.Value;
            int level = Int32.Parse(comboBox1.Text);
            string content = richTextBox1.Text;
            DailyEntity workDay = DailyManager.GetDaily(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            WorkEntity newwork = new WorkEntity(workname, starttime, endtime, level, content, workDay);
            WorkManager.AddWork(workDay, newwork);
            f1.Renew();
            this.Close();
        }
    }
}
