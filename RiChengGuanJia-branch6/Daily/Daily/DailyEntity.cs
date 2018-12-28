using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    public class DailyEntity
    {
        #region 成员变量
        public List<WorkEntity> works = new List<WorkEntity>();
        #endregion
        #region 属性
        /// <summary>
        /// 当日事务
        /// </summary>
        public List<WorkEntity> Works { get => this.works; set { this.works = value; } }
        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// 月
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// 日
        /// </summary>
        public int Day { get; set; }
        /// <summary>
        /// 星期几
        /// </summary>
        public int WeekDay { get; set; }
        #endregion

        public override string ToString()
        {
            //AllDailys这个dictionary里的key
            return $"{Year}Y{Month}M{Day}D";
        }
        //对一日事务都进行排序
        
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public DailyEntity() { }
        public DailyEntity(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
            WeekDay = (int)new DateTime(year, month, day).DayOfWeek;
            
            //WeekDay = weekday;
        }
        #endregion
    }
}
