using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Daily
{
    public class WorkEntity
    {
        #region 属性
        /// <summary>
        /// 编号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 事务名称
        /// </summary>
        public string WorkName { get; set; }
        /// <summary>
        /// 事务开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 事务结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 事务优先级
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 事务内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 父事务
        /// </summary>
        //public WorkEntity SuperWork { get; set; }
        /// <summary>
        /// 子事务
        /// </summary>
        //public List<WorkEntity> SubWork { get; set; }
        /// <summary>
        /// 事务颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 所属日期
        /// </summary>
        public DailyEntity Daily { get; set; }
        /// <summary>
        /// 是否已完成
        /// </summary>
        public bool IsEnd { get; set; }
        /// <summary>
        /// 提醒次数
        /// </summary>
        public int count { get; set; }

        #endregion

        public override string ToString()
        {
            return WorkName + StartTime.ToString();
        }

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkEntity() { }
        public WorkEntity(string workname, DateTime starttime, DateTime endtime, int level, string content, DailyEntity daily, string color = "white")
        {
            WorkName = workname;
            StartTime = starttime;
            EndTime = endtime;
            Level = level;
            Content = content;
            Daily = daily;
            Color = color;
            ID = this.ToString();
        }
        #endregion
    }
}
