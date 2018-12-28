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
    public partial class Form8 : Form
    {
        Form1 f1;
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(Form1 f):this()
        {
            f1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskname = textBox1.Text;
            DateTime endtime = dateTimePicker1.Value;
            int lev = Int32.Parse(comboBox1.Text);
            string content = richTextBox1.Text;
            TaskManager.AddTask(new TaskEntity(taskname, endtime, lev, content));
            f1.Recenttasks = TaskManager.ChooseTasks(f1.thisDay);
            f1.Renew();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
