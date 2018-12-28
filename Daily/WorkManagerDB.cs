using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    public class WorkManagerDB
    {
        /// <summary>
        /// 所有事务
        /// </summary>
        //public static Dictionary<string, WorkEntity> AllWorks { get; set; }

        #region 静态函数
        /// <summary>
        /// 获取事务管理类
        /// </summary>
        public static WorkManagerDB GetInstance()
        {
            WorkManagerDB WM;
            if (true)
            {
                WM = new WorkManagerDB();
            }
            return WM;
        }
        /// <summary>
        /// 为某一天添加一个事务
        /// </summary>
        public static bool AddWork(DailyEntity daily, WorkEntity work)
        {
            using (var db = new DailyDB())
            {
                db.WorkEntity.Add(work);
                db.SaveChanges();
            }
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
            if (work != null)
            {
                using (var db = new DailyDB())
                {
                    var worktodel = db.WorkEntity.SingleOrDefault(w => w.ID == work.ID);
                    db.WorkEntity.Remove(worktodel);
                    db.SaveChanges();
                }
                work.GetDaily().Works.Remove(work);
                GlobalVariable.AllWorks.Remove(work);
            }
            return true;
        }
        /// <summary>
        /// 修改一个事务
        /// </summary>
        public static bool ModifyWork(WorkEntity work)
        {
            return true;
        }

        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkManagerDB() { }
        #endregion
    }
}
