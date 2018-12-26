using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    public class TaskEntity
    {
        #region 属性
        /// <summary>
        /// 编号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }
        /// <summary>
        /// 任务结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 任务优先级
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 任务内容
        /// </summary>
        public string Content { get; set; }                
        /// <summary>
        /// 是否已完成
        /// </summary>
        public bool IsEnd { get; set; }

        #endregion

        public override string ToString()
        {
            return TaskName + EndTime.ToString();
        }

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public TaskEntity() { }
        public TaskEntity(string taskname, DateTime endtime, int level, string content)
        {
            TaskName = taskname;
            
            EndTime = endtime;
            Level = level;
            Content = content;           
            ID = this.ToString();
        }
        #endregion
    }
}
