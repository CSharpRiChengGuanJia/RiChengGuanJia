using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    public class WorkManager
    {
        /// <summary>
        /// 所有事务
        /// </summary>
        //public static Dictionary<string, WorkEntity> AllWorks { get; set; }

        #region 静态函数
        /// <summary>
        /// 获取事务管理类
        /// </summary>
        public static WorkManager GetInstance()
        {
            WorkManager WM;
            if (true)
            {
                WM = new WorkManager();
            }
            return WM;
        }
        /// <summary>
        /// 为某一天添加一个事务
        /// </summary>
        public static bool AddWork(DailyEntity daily, WorkEntity work)
        {
            daily.Works.Add(work);
            DailyManager.SortWorks(daily);
            GlobalVariable.AllWorks.Add(work);
            WorkManager.SortWork();
            return true;
        }
        /// <summary>
        /// 删除一个事务
        /// </summary>
        public static bool DelWork(WorkEntity work)
        {
            work.Daily.Works.Remove(work);
            GlobalVariable.AllWorks.Remove(work);
            return true;
        }
        /// <summary>
        /// 修改一个事务
        /// </summary>
        public static bool ModifyWork(WorkEntity work)
        {
            return true;
        }
        //对事物排序
        public static void SortWork()
        {
            var m = from n in GlobalVariable.AllWorks orderby n.StartTime select n;
            List<WorkEntity> reworks = new List<WorkEntity>();
            foreach(var n in m)
            {
                reworks.Add(n);
            }
            GlobalVariable.AllWorks = reworks;
        }
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkManager() { }
        #endregion
    }
}
