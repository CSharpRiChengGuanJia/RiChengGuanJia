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
    public partial class Form3 : Form
    {
        Form1 f1;
        string id = "";
        WorkEntity workToModify = null;
        public Form3()
        {
            InitializeComponent();            
        }
        public Form3(Form1 f1) : this()
        {
            this.f1 = f1;
            id = f1.GetId(); 
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
            //其实编辑事务就是新建一个事务同时然后删掉原来那个事务
            //WorkManager.DelWork(workToModify);
            WorkManagerDB.DelWork(workToModify);
            string workname = textBox1.Text;
            DateTime starttime = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second);
            DateTime endtime = new DateTime(f1.thisDay.Year, f1.thisDay.Month, f1.thisDay.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
            int level = Int32.Parse(comboBox1.Text);
            string content = richTextBox1.Text;            
            WorkEntity newwork = new WorkEntity(workname, starttime, endtime, level, content, f1.thisDay);
            //WorkManager.AddWork(f1.thisDay, newwork);
            WorkManagerDB.AddWork(f1.thisDay, newwork);
            f1.Renew();
            this.Close();
        }
    }
}
