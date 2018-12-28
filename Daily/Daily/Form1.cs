﻿using System;
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

        public Form1()
        {
            InitializeComponent();
            GlobalVariable.TestInit(); //先随便初始化几个事务，用来测试
            bindingSource1.DataSource = GlobalVariable.AllWorks; //暂时把首页数据绑定为全部事务
        }
        public Form1(DailyEntity dailyEntity) : this()
        {
            thisDay = dailyEntity;//当前界面对应的那天
            bindingSource1.DataSource = thisDay.Works; //列表的数据绑定为这一天的事务集合
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
            bindingSource3.DataSource = new List<WorkEntity>();
            bindingSource3.DataSource = GlobalVariable.AllWorks;
        }

        //获取选中行（事务）的id，用于检索事务
        public string GetId()
        {
            return dataGridView1.CurrentRow.Cells[6].Value.ToString();
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
            bindingSource1.DataSource = thisDay.Works;
            tabControl1.SelectTab(0);
            TextInit();
        }

        //后一天
        private void button8_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(thisDay.Year, thisDay.Month, thisDay.Day).AddDays(1);
            thisDay = DailyManager.GetDaily(date.Year, date.Month, date.Day);
            bindingSource1.DataSource = thisDay.Works;
            tabControl1.SelectTab(0);
            TextInit();
        }

        //导入日程
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            f4.ShowDialog();
        }

        //事务一览界面添加任务
        private void button11_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(this);
            f7.ShowDialog();
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
    }
}
