using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    class TaskManagerDB
    {

        #region 静态函数
        /// <summary>
        /// 获取事务管理类
        /// </summary>
        public static TaskManagerDB GetInstance()
        {
            TaskManagerDB TM;
            if (true)
            {
                TM = new TaskManagerDB();
            }
            return TM;
        }
        /// <summary>
        /// 添加一个任务
        /// </summary>
        public static bool AddTask(TaskEntity task)
        {
            using (var db = new DailyDB())
            {
                db.TaskEntity.Add(task);
                db.SaveChanges();
            }
            GlobalVariable.AllTasks.Add(task);
            SortTasks();
            return true;
        }
        /// <summary>
        /// 删除一个任务
        /// </summary>
        public static bool DelTask(TaskEntity task)
        {
            using (var db = new DailyDB())
            {
                var tasktodel = db.TaskEntity.SingleOrDefault(w => w.ID == task.ID);
                db.TaskEntity.Remove(tasktodel);
                db.SaveChanges();
            }
            GlobalVariable.AllTasks.Remove(task);
            return true;
        }
        /// <summary>
        /// 修改一个任务
        /// </summary>
        public static bool ModifyTask(TaskEntity task)
        {
            return true;
        }

        //对所有任务进行排序(重载)
        public static void SortTasks()
        {
            var m = from n in GlobalVariable.AllTasks orderby n.EndTime select n;
            List<TaskEntity> retasks = new List<TaskEntity>();
            foreach (var n in m)
            {
                retasks.Add(n);
            }
            GlobalVariable.AllTasks = retasks;
        }
        public static void SortTasks(List<TaskEntity> list)
        {
            var m = from n in list orderby n.EndTime select n;
            List<TaskEntity> retasks = new List<TaskEntity>();
            foreach (var n in m)
            {
                retasks.Add(n);
            }
            list = retasks;
        }
        ///<summary>
        ///筛选近期任务并排序
        /// </summary>
        public static List<TaskEntity> ChooseTasks(DailyEntity thisday)
        {
            List<TaskEntity> choosentasks = new List<TaskEntity>();
            DateTime now = new DateTime(thisday.Year, thisday.Month, thisday.Day);
            var m = from n in GlobalVariable.AllTasks where Math.Abs((n.EndTime - now).Days) <= 3 orderby n.EndTime select n;
            foreach (var n in m)
            {
                choosentasks.Add(n);
            }
            return choosentasks;
        }
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public TaskManagerDB() { }
        #endregion
    }
}
