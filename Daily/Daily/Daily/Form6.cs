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
    public partial class Form6 : Form
    {
        Form1 f1;
        string id = "";
        WorkEntity workToModify = null;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(Form1 f1) : this()
        {
            this.f1 = f1;
            id = f1.GetId1();
            foreach (WorkEntity work in GlobalVariable.AllWorks)
            {
                if (work.ID == id)
                {
                    workToModify = work;
                    break;
                }
            }
            textBox1.Text = workToModify.WorkName;
            dateTimePicker1.Value = workToModify.StartTime;
            dateTimePicker2.Value = workToModify.EndTime;
            comboBox1.Text = workToModify.Level.ToString();
            richTextBox1.Text = workToModify.Content;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkManager.DelWork(workToModify);
            string workname = textBox1.Text;
            DateTime starttime = dateTimePicker1.Value;
            DateTime endtime = dateTimePicker2.Value;
            int level = Int32.Parse(comboBox1.Text);
            string content = richTextBox1.Text;
            if (starttime < endtime)
            {
                DailyEntity workDay = DailyManager.GetDaily(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                WorkEntity newwork = new WorkEntity(workname, starttime, endtime, level, content, workDay);
                WorkManager.AddWork(workDay, newwork);
                f1.Renew();
                this.Close();
            }
            else
            {
                MessageBox.Show("时间输入错误","ERROR");
            }
            
        }
    }
}
