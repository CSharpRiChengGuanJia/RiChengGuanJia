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
            string str = $"{daily.Day}{daily.Month}{daily.Day}"; //这里暂时有个问题：1月23日和12月3日的key是一样的
            GlobalVariable.AllDailys.Add(str, daily);
            return true;
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
