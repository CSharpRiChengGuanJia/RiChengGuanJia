using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    public class DailyManager
    {
        /// <summary>
        /// 所有有事务的日期
        /// </summary>
        //public static Dictionary<string, DailyEntity> AllDailys { get; set; }
        
        #region 静态函数
        /// <summary>
        /// 获取每日管理类
        /// </summary>
        public static DailyManager GetInstance()
        {
            DailyManager DM;
            if (true)
            {
                 DM = new DailyManager();
            }
            return DM;
        }
        /// <summary>
        /// 新建一个Daily对象
        /// </summary>
        public static bool AddDaily(DailyEntity daily)
        {
            string str = $"{daily.Year}Y{daily.Month}M{daily.Day}D"; 
            GlobalVariable.AllDailys.Add(str, daily);
            return true;
        }
        ///<summary>
        ///对每日事务进行排序
        /// </summary>
        public static void SortWorks(DailyEntity thisDay)
        {
            var m = from n in thisDay.Works orderby n.StartTime select n;
             List<WorkEntity> reworks = new List<WorkEntity>();
            foreach (var n in m)
            {
                reworks.Add(n);
            }
            thisDay.Works = reworks;
        }
/// <summary>
/// 获取一个Daily对象
/// </summary>
     public static DailyEntity GetDaily(int year, int month, int day)
        {
            string str = $"{year}Y{month}M{day}D";  //AllDailys这个dictionary里的key
            //先检索AllDailys里有没有存在这个key了
            if (GlobalVariable.AllDailys.ContainsKey(str))
            {
                return GlobalVariable.AllDailys[str];
            }
            else
            {
                //如果没有，那就new一个加进去
                DailyEntity dailyEntity = new DailyEntity(year, month, day);
                AddDaily(dailyEntity);
                return dailyEntity;
            }

        }
        /// <summary>
        /// 删除当天所有事务
        /// </summary>
        public static bool DelAllWorkOnTheDay(DailyEntity daily)
        {
            daily.Works.Clear();
            return true;
        }
        /// <summary>
        /// 导入日程
        /// </summary>
        public static bool ImportDaily(DailyEntity todaily, DailyEntity fromdaily)
        {
            todaily.Works = new List<WorkEntity>(fromdaily.Works);
            return true;
        }

        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public DailyManager() { }
        #endregion
    }
}
