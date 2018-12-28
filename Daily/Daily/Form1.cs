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
    public partial class Form1 : Form
    {
        //public GlobalVariable Global = new GlobalVariable();
        public DailyEntity thisDay = null; //当前界面对应的那天
        public List<TaskEntity> Recenttasks = new List<TaskEntity>();//近期任务
        public Form1()
        {
            InitializeComponent();
            GlobalVariable.TestInit();//先随便初始化几个事务，用来测试
            WorkManager.SortWork();//对全部事务进行排序
            bindingSource1.DataSource = GlobalVariable.AllWorks; //暂时把首页数据绑定为全部事务
            bindingSource4.DataSource = GlobalVariable.AllTasks;//把首页近期任务绑定为全部任务
            axWindowsMediaPlayer1.URL = @"C:\Users\Vermouth\Desktop\music.mp3";
            axWindowsMediaPlayer1.close();
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }
        public Form1(DailyEntity dailyEntity) : this()
        {
            thisDay = dailyEntity;//当前界面对应的那天
            Recenttasks = TaskManager.ChooseTasks(thisDay);//当前界面对应的近期任务
            DailyManager.SortWorks(thisDay);//对一日事物进行排序
            bindingSource1.DataSource = thisDay.Works; //列表的数据绑定为这一天的事务集合
            bindingSource2.DataSource = Recenttasks;//列表的数据绑定为最近的任务集合
            //bindingSource1.DataSource = new BindingList<WorkEntity>(thisDay.Works); //如果要排序，要转换成这种类
            //dataGridView1.Sort(dataGridView1.Columns[1], 0); //排序（会报错）
            bindingSource3.DataSource = GlobalVariable.AllWorks;  //这个是事务一览那个界面的列表
            
            //以下3个textbox是在“查看日历”里面的那3个框框
            textBox1.Text = thisDay.Year.ToString();
            textBox2.Text = thisDay.Month.ToString();
            textBox3.Text = thisDay.Day.ToString();
            TextInit();
        }

        //刷新某些文字
        public void TextInit()
        {
            label5.Text = $"{thisDay.Year}年 {thisDay.Month}月 {thisDay.Day}日 {(DayOfWeek)thisDay.WeekDay}";
        }

        //刷新事务列表
        public void Renew()
        {
            //把数据源重新赋值一下就可以刷新了
            bindingSource1.DataSource = new List<WorkEntity>();
            bindingSource1.DataSource = thisDay.Works;
            bindingSource2.DataSource = Recenttasks;
            bindingSource3.DataSource = new List<WorkEntity>();
            bindingSource3.DataSource = GlobalVariable.AllWorks;
            bindingSource4.DataSource = new List<TaskEntity>();
            bindingSource4.DataSource = GlobalVariable.AllTasks;
        }

        //获取选中行（事务）的id，用于检索事务
        public string GetId()
        {
            return dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        //获取选中行（任务）的ID，用于检索任务
        public string GetTID()
        {
            return dataGridView4.CurrentRow.Cells[1].Value.ToString();
        }

        //获取事务一览中的id
        public string GetId1()
        {
            return dataGridView3.CurrentRow.Cells[6].Value.ToString();
        }


        //添加事务
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        //删除事务
        private void button3_Click(object sender, EventArgs e)
        {
            WorkEntity workToDel = null;
            foreach(WorkEntity work in GlobalVariable.AllWorks)
            {
                if (work.ID == GetId())
                {
                    workToDel = work;
                    break;
                }
            }
            WorkManager.DelWork(workToDel);
            Renew();
        }
        //删除任务
        private void button9_Click(object sender, EventArgs e)
        {
            TaskEntity ta = null;
            foreach (TaskEntity n in GlobalVariable.AllTasks)
            {
                if (n.ID ==GetTID())
                {
                    ta = n;
                    break;
                }
            }
            TaskManager.DelTask(ta);
            Renew();
        }
        //编辑事务
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }

        //没用，不小心点出来的。。
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //“查看日历”界面的确定按钮
        private void button5_Click(object sender, EventArgs e)
        {
            thisDay = DailyManager.GetDaily(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
            bindingSource1.DataSource = thisDay.Works;
            tabControl1.SelectTab(0); //切换到第一个页面
            TextInit();
        }

        //Home按钮（显示今日的日程）
        private void button6_Click(object sender, EventArgs e)
        {
            thisDay = DailyManager.GetDaily(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            bindingSource1.DataSource = thisDay.Works;
            tabControl1.SelectTab(0);
            TextInit();
        }

        //前一天
        private void button7_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(thisDay.Year, thisDay.Month, thisDay.Day).AddDays(-1);
            thisDay = DailyManager.GetDaily(date.Year, date.Month, date.Day);
            Recenttasks = TaskManager.ChooseTasks(thisDay);
            bindingSource1.DataSource = thisDay.Works;
            
            tabControl1.SelectTab(0);
            Renew();
            TextInit();
        }

        //后一天
        private void button8_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(thisDay.Year, thisDay.Month, thisDay.Day).AddDays(1);
            thisDay = DailyManager.GetDaily(date.Year, date.Month, date.Day);
            Recenttasks = TaskManager.ChooseTasks(thisDay);
            bindingSource1.DataSource = thisDay.Works;
            tabControl1.SelectTab(0);
            Renew();
            TextInit();
        }

        //导入日程
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            f4.ShowDialog();
        }

        //添加任务
        private void button11_Click(object sender, EventArgs e)
        {
            Form f8 = new Form8(this);
            f8.ShowDialog();
        }
        //编辑任务
        private void button10_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(this);
            f9.ShowDialog();
        }

        //事务一览界面添加事务
        private void button12_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this);
            f5.ShowDialog();
        }

        //事务一览界面编辑事务
        private void button13_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(this);
            f6.ShowDialog();
        }

        //事务一览界面删除事务
        private void button14_Click(object sender, EventArgs e)
        {
            WorkEntity workToDel = null;
            foreach (WorkEntity work in GlobalVariable.AllWorks)
            {
                if (work.ID == GetId1())
                {
                    workToDel = work;
                    break;
                }
            }
            WorkManager.DelWork(workToDel);
            Renew();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(WorkEntity we in GlobalVariable.AllWorks)
            {
                if (!we.IsEnd)
                {

                    TimeSpan ts1 = new TimeSpan(we.StartTime.Ticks);
                    TimeSpan ts2 = new TimeSpan(DateTime.Now.Ticks);
                    TimeSpan ts3 = ts2.Subtract(ts1); 
                    double sumSeconds = (ts3.TotalSeconds);
                    if (sumSeconds > 0)
                    {
                        if (sumSeconds < 60 * decimal.ToDouble(numericUpDown1.Value)*decimal.ToDouble(numericUpDown2.Value))
                        {
                            timer1.Interval = 60000 * Decimal.ToInt32(numericUpDown2.Value);
                            timer1.Enabled = false;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            Form10 f = new Form10(we);
                            f.ShowDialog();
                            axWindowsMediaPlayer1.close();
                            timer1.Enabled = true;
                        }
                        else
                            we.IsEnd = true;
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "常见音频文件(*.mp3;*.wav;*.wma;*.mid;*.asf)|*.mp3;*.wav;*.wma;*.mid;*.asf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox4.Text = openFileDialog1.FileName;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            axWindowsMediaPlayer1.close();
            tabControl1.SelectTab(0); //切换到第一个页面
       
        }
    }
}
