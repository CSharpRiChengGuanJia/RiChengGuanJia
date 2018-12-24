using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Daily.Custom_Control
{
    public partial class CalendarPage : UserControl
    {
        public CalendarPage()
        {
            InitializeComponent();
            
        }
        private DateTime dateTime = DateTime.Now;           //获取现在的时间
        private static int year = DateTime.Now.Year;
        private static int chosenYear = year;
        private static int month = DateTime.Now.Month;
        private static int chosenMonth = month;
        private void CalendarPage_Load(object sender, EventArgs e)
        {
            DisplayDay(dateTime);
            #region 设置年月
            labelYear.Text = DateTime.Now.Year.ToString();
            
            chosenYear = year;
            chosenMonth = month;
            //在此定义一个月的数组方便下面使用
            Month[] Month = new Month[12];
            Month[0] = month1;
            Month[1] = month2;
            Month[2] = month3;
            Month[3] = month4;
            Month[4] = month5;
            Month[5] = month6;
            Month[6] = month7;
            Month[7] = month8;
            Month[8] = month9;
            Month[9] = month10;
            Month[10] = month12;
            Month[11] = month11;
          
            #endregion
        }
        #region 根据年月获得当月天数  格里历算法
        public int daysInMonth(int year, int month)
        {
            int days = 0;
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12: days = 31; break;
                case 4: case 6: case 9: case 11: days = 30; break;
                case 2:
                    if ((year % 100 != 0 && year % 4 == 0) || (year % 400 == 0)) days = 29;
                    else days = 28;
                    break;
                default: days = 0; break;
            }
            return days;
        }
        #endregion
        #region 构造日历
        public void AddDay(Day day, int x, int y)
        {
            
            day.Location = new Point(43 + (x * 100), 10 + (53 * y));
            //day.BackColor = Color.FromArgb(75, Color.Black);
            panelDay.Controls.Add(day);
            
        }
        
        public void DisplayDay(DateTime datetime)
        {
            panelDay.Controls.Clear();
            int dim = this.daysInMonth(chosenYear, chosenMonth);  //获取选中年月
            Day[] days = new Day[dim];
            for(int d = 0; d < dim; d++)
            {
                days[d] = new Day();
                days[d].Name = "Day" + (d + 1).ToString();
                days[d].Text = (d + 1).ToString();
                int a = Convert.ToInt32(days[d].Text);
                if(a >= 10)
                {
                    days[d].label.Location = new Point(days[d].label.Location.X - 7, days[d].label.Location.Y);
                }
                if((d + 1) == datetime.Day && chosenYear == datetime.Year && chosenMonth == datetime.Month)
                {
                    days[d].BackColor = Color.FromArgb(120, Color.Orange);//设置颜色
                    
                }
            }
            int index = 0;
            DateTime firstDayTime = new DateTime(chosenYear, chosenMonth, 1);
            int firstDay = (int)firstDayTime.DayOfWeek;
            for(int i = 0; i < 6; i++)                        //添加块
            {
                for(int j = 0; j < 7; j++)
                {
                    if (i == 0 && j < firstDay) { }
                    else if(index < dim)
                    {
                        AddDay(days[index], j, i); 
                        index++;
                    }
                    
                }
            }
        }

        #endregion
        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            chosenYear -= 1;
            labelYear.Text = chosenYear.ToString();
            DisplayDay(dateTime);
            this.Refresh();
        }

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            chosenYear += 1;
            labelYear.Text = chosenYear.ToString();
            DisplayDay(dateTime);
            this.Refresh();
        }


        #region 点击月份

        

        private void month1_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month1.anyText);
            
            DisplayDay(dateTime);
        }

        private void month2_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month2.anyText);
            DisplayDay(dateTime);
        }

        private void month3_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month3.anyText);
            DisplayDay(dateTime);
        }

        private void month4_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month4.anyText);
            DisplayDay(dateTime);
        }

        private void month5_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month5.anyText);
            DisplayDay(dateTime);
        }

        private void month6_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month6.anyText);
            DisplayDay(dateTime);
        }

        private void month7_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month7.anyText);
            DisplayDay(dateTime);
        }

        private void month8_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month8.anyText);
            DisplayDay(dateTime);
        }

        private void month9_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month9.anyText);
            DisplayDay(dateTime);
        }

        private void month10_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month10.anyText);
            DisplayDay(dateTime);
        }

        private void month11_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month11.anyText);
            DisplayDay(dateTime);
        }

        private void month12_Click(object sender, EventArgs e)
        {
            chosenMonth = Convert.ToInt32(month12.anyText);
            DisplayDay(dateTime);
        }
        #endregion

       
        private void labelYear_DoubleClick(object sender, EventArgs e)
        {
            textBoxYear.BackColor = labelYear.BackColor;
            textBoxYear.Visible = true;
            textBoxYear.Location = labelYear.Location;
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            chosenMonth = month;
            chosenYear = year;
            DisplayDay(dateTime);
        }
    }
}
