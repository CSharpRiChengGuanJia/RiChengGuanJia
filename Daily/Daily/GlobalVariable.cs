using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    /// <summary>
    /// 全局处理类，包括全局成员变量等
    /// </summary>
    public class GlobalVariable
    {

        #region 全局变量
        //public DailyManager DM = DailyManager.GetInstance();
        //public WorkManager WM = WorkManager.GetInstance();
        #region 成员变量
        public static Dictionary<string, DailyEntity> allDailys = new Dictionary<string, DailyEntity>();
        public static List<WorkEntity> allworks = new List<WorkEntity>();
        #endregion
        /// <summary>
        /// 所有有事务的日期
        /// </summary>
        public static Dictionary<string, DailyEntity> AllDailys { get => allDailys; set { allDailys = value; } }
        /// <summary>
        /// 所有事务
        /// </summary>
        public static List<WorkEntity> AllWorks { get => allworks; set { allworks = value; } }

        #endregion

        /// <summary>
        /// 测试用的初始化
        /// </summary>
        public static void TestInit()
        {
            DateTime now = DateTime.Now;
            DailyEntity today = new DailyEntity(now.Year, now.Month, now.Day);
            DailyManager.AddDaily(today);
            WorkEntity work1 = new WorkEntity("午睡", new DateTime(today.Year, today.Month, today.Day, 12, 45, 0),
                new DateTime(today.Year, today.Month, today.Day, 13, 45, 0), 5, "午睡。。。", today);
            WorkEntity work2 = new WorkEntity("写形策论文", new DateTime(today.Year, today.Month, today.Day, 14, 00, 0),
                new DateTime(today.Year, today.Month, today.Day, 15, 30, 0), 5, "截止日期25日，详情见班群通知", today);
            WorkEntity work3 = new WorkEntity("图书馆自习", new DateTime(today.Year, today.Month, today.Day, 18, 30, 0),
                new DateTime(today.Year, today.Month, today.Day, 21, 30, 0), 5, "信图3楼东社会科学区046号", today);
            WorkManager.AddWork(today, work1);
            WorkManager.AddWork(today, work2);
            WorkManager.AddWork(today, work3);
        }
    }
}
