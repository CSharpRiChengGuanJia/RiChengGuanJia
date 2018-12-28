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
        public static int chosenYear = year;
        private static int month = DateTime.Now.Month;
        public static int chosenMonth = month;
        private void CalendarPage_Load(object sender, EventArgs e)
        {
            DisplayMonth();
            DisplayDay(dateTime);
            #region 设置年月
            labelYear.Text = DateTime.Now.Year.ToString();
            
            chosenYear = year;
            chosenMonth = month;
           

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

       
        public void DisplayMonth()
        {

            Month[] months = new Month[12];
            for (int m = 0; m < 12; m++)
            {
                months[m] = new Month();
                months[m].Text = (m + 1).ToString();
                months[m].Name = "month" + (m + 1).ToString();
                panelTop.Controls.Add(months[m]);
                months[m].Location = new Point(178 + (46 * m), 42);
                if (m >= 9)
                    months[m].label.Location = new Point(months[m].label.Location.X - 5, months[m].label.Location.Y);
                if ((m + 1) == dateTime.Month)
                    months[m].BackColor = Color.FromArgb(120, Color.Orange);
            }
            
        }
        
        
        public void DisplayDay(DateTime datetime)
        {
            panelDay.Controls.Clear();
            int dim = this.daysInMonth(chosenYear, chosenMonth);  //获取选中年月
            Day[] days = new Day[dim];
           
            for (int d = 0; d < dim; d++)
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


       

        

       

       
        //private void labelYear_DoubleClick(object sender, EventArgs e)
        //{
        //    textBoxYear.BackColor = labelYear.BackColor;
        //    textBoxYear.Visible = true;
        //    textBoxYear.Location = labelYear.Location;
        //}

        private void buttonToday_Click(object sender, EventArgs e)
        {
            chosenMonth = month;
            chosenYear = year;
            labelYear.Text = chosenYear.ToString();
            DisplayDay(dateTime);
        }

        private void buttonJump_Click(object sender, EventArgs e)
        {

        }

       
    }
}
