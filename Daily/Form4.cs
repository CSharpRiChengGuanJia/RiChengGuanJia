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
    public partial class Form4 : Form
    {
        Form1 f1;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form1 f1) : this()
        {
            this.f1 = f1;
            textBox1.Text = f1.thisDay.Year.ToString();
            textBox2.Text = f1.thisDay.Month.ToString();
            textBox3.Text = f1.thisDay.Day.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DailyEntity fromDay = DailyManager.GetDaily(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
            foreach (WorkEntity work in fromDay.Works)
            {
                var delta = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day) - new DateTime(fromDay.Year, fromDay.Month, fromDay.Day);
                WorkEntity newWork = new WorkEntity(work.WorkName, work.StartTime + delta, work.EndTime + delta, work.Level, work.Content, work.GetDaily());
                //WorkManager.AddWork(f1.thisDay, newWork);
                WorkManagerDB.AddWork(f1.thisDay, newWork);
                f1.Renew();
                this.Close();
            }
        }
    }
}
