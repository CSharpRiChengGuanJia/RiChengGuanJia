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

        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public TaskManager() { }
        #endregion
    }
}
