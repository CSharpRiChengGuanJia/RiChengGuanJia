using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    class TaskManager
    {

        #region 静态函数
        /// <summary>
        /// 获取事务管理类
        /// </summary>
        public static TaskManager GetInstance()
        {
            TaskManager TM;
            if (true)
            {
                TM = new TaskManager();
            }
            return TM;
        }
        /// <summary>
        /// 添加一个任务
        /// </summary>
        public static bool AddTask(TaskEntity task)
        {
            GlobalVariable.AllTasks.Add(task);
            SortTasks();
            return true;
        }
        /// <summary>
        /// 删除一个任务
        /// </summary>
        public static bool DelTask(TaskEntity task)
        {
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
        public  static List<TaskEntity> ChooseTasks()
        {
            List<TaskEntity> choosentasks = new List<TaskEntity>();
            DateTime now = DateTime.Now;
            var m = from n in GlobalVariable.AllTasks where (n.EndTime - now).Days <= 3 orderby n.EndTime select n;
            foreach(var n in m)
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
        public TaskManager() { }
        #endregion
    }
}
