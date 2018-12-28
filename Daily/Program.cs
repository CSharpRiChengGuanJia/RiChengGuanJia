using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(DailyManager.GetDaily(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))); //刚打开应用程序显示的就是系统时间的今天的日程
        }
    }
}
