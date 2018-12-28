using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
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
        public static List<TaskEntity> alltasks = new List<TaskEntity>();
        #endregion
        /// <summary>
        /// 所有有事务的日期
        /// </summary>
        public static Dictionary<string, DailyEntity> AllDailys { get => allDailys; set { allDailys = value; } }
        /// <summary>
        /// 所有事务
        /// </summary>
        public static List<WorkEntity> AllWorks { get => allworks; set { allworks = value; } }
        /// <summary>
        /// 所有任务
        /// </summary>
        public static List<TaskEntity> AllTasks { get => alltasks; set { alltasks = value; } }

        #endregion

        /// <summary>
        /// 测试用的初始化
        /// </summary>
        public static void TestInit()
        {
            DateTime now = DateTime.Now;
            DailyEntity today = DailyManager.GetDaily(now.Year, now.Month, now.Day);
            //DailyManager.AddDaily(today);
            WorkEntity work1 = new WorkEntity("午睡", new DateTime(today.Year, today.Month, today.Day, 15, 45, 0),
                new DateTime(today.Year, today.Month, today.Day, 13, 45, 0), 5, "午睡。。。", today);
            WorkEntity work2 = new WorkEntity("写形策论文", new DateTime(today.Year, today.Month, today.Day, 14, 00, 0),
                new DateTime(today.Year, today.Month, today.Day, 15, 30, 0), 5, "截止日期25日，详情见班群通知", today);
            WorkEntity work3 = new WorkEntity("图书馆自习", new DateTime(today.Year, today.Month, today.Day, 18, 30, 0),
                new DateTime(today.Year, today.Month, today.Day, 21, 30, 0), 5, "信图3楼东社会科学区046号", today);
            TaskEntity task1 = new TaskEntity("汉姆", new DateTime(2019, 7, 1), 1, "天天跑步");
            TaskEntity task2 = new TaskEntity("上学", new DateTime(2017, 6, 1), 2, "天天上学");
            TaskManager.AddTask(task1);
            TaskManager.AddTask(task2);
            TaskManager.SortTasks();
            WorkManager.AddWork(today, work1);
            WorkManager.AddWork(today, work2);
            WorkManager.AddWork(today, work3);
            
        }
        /// <summary>
        /// 测试用的初始化2（数据库）
        /// </summary>
        public static void TestInit2()
        {
            DateTime now = DateTime.Now;
            DailyEntity today = DailyManager.GetDaily(now.Year, now.Month, now.Day);
            TaskEntity task1 = new TaskEntity("汉姆", new DateTime(2019, 7, 1), 1, "天天跑步");
            TaskEntity task2 = new TaskEntity("上学", new DateTime(2017, 6, 1), 2, "天天上学");
            TaskManager.AddTask(task1);
            TaskManager.AddTask(task2);
            TaskManager.SortTasks();
            List<WorkEntity> tmpworklist = new List<WorkEntity>();
            //WorkEntity work3 = new WorkEntity("图书馆自习", new DateTime(today.Year, today.Month, today.Day, 18, 30, now.Second),
            //    new DateTime(today.Year, today.Month, today.Day, 21, 30, 0), 5, "信图3楼东社会科学区046号", today);
            //WorkManagerDB.AddWork(today, work3);
            using (var db = new DailyDB())
            {
                db.WorkEntity.ToList<WorkEntity>();
                tmpworklist = db.WorkEntity.ToList<WorkEntity>();
            }
            foreach(WorkEntity work in tmpworklist)
            {
                WorkManager.AddWork(DailyManager.GetDaily(work.StartTime.Year, work.StartTime.Month, work.StartTime.Day), work);

            }

        }
        // <T> is the type of data in the list.
        // If you have a List<int>, for example, then call this as follows:
        // List<int> ListOfInt;
        // DataTable ListTable = BuildDataTable<int>(ListOfInt);
        public static DataTable BuildDataTable<T>(IList<T> lst)
        {
            //create DataTable Structure
            DataTable tbl = CreateTable<T>();
            Type entType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
            //get the list item and add into the list
            foreach (T item in lst)
            {
                DataRow row = tbl.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }
                tbl.Rows.Add(row);
            }
            return tbl;
        }
        private static DataTable CreateTable<T>()
        {
            //T –> ClassName
            Type entType = typeof(T);
            //set the datatable name as class name
            DataTable tbl = new DataTable(entType.Name);
            //get the property list
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
            foreach (PropertyDescriptor prop in properties)
            {
                //add property as column
                tbl.Columns.Add(prop.Name, prop.PropertyType);
            }
            return tbl;
        }
        /// <summary>
        /// List<T>转DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T> list)
        {
            DataTable result = new DataTable();
            List<PropertyInfo> pList = new List<PropertyInfo>();
            Type type = typeof(T);
            Array.ForEach<PropertyInfo>(type.GetProperties(), prop => { pList.Add(prop); result.Columns.Add(prop.Name, prop.PropertyType); });
            foreach (var item in list)
            {
                DataRow row = result.NewRow();
                pList.ForEach(p => row[p.Name] = p.GetValue(item, null));
                result.Rows.Add(row);
            }
            return result;
        }
    }
}
