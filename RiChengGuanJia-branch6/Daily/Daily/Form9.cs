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
    public partial class Form9 : Form
    {
        Form1 f1;
        string id = "";
        TaskEntity ModifyTask = null;
        public Form9()
        {
            InitializeComponent();
        }
        public Form9(Form1 f):this()
        {
            f1 = f;
            id = f.GetTID();
            foreach(TaskEntity task in GlobalVariable.AllTasks)
            {
                if(task.ID==id)
                {
                    ModifyTask = task;
                    break;
                }
            }
            textBox1.Text = ModifyTask.TaskName;
            dateTimePicker1.Value = ModifyTask.EndTime;
            comboBox1.Text = ModifyTask.Level.ToString();
            richTextBox1.Text = ModifyTask.Content;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskManager.DelTask(ModifyTask);
           string taskname = textBox1.Text;
            int lev = Int32.Parse(comboBox1.Text);
            DateTime end = dateTimePicker1.Value;
            string cont = richTextBox1.Text;
            TaskEntity newTask = new TaskEntity(taskname, end , lev,cont);
            TaskManager.AddTask(newTask);
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
