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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f1): this()
        {
            this.f1 = f1;
            dateTimePicker1.Value = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            dateTimePicker2.Value = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//改成了只能添加当日的事务，任意一日的事务从事务一览中添加
        {
            string workname = textBox1.Text;
            DateTime starttime = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second);
            DateTime endtime = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
            int level = Int32.Parse(comboBox1.Text);
            string content = richTextBox1.Text;           
            WorkEntity newwork = new WorkEntity(workname, starttime, endtime, level, content, f1.thisDay);
            WorkManager.AddWork(f1.thisDay, newwork);
            f1.Renew();
            this.Close();
        }
    }
}
