using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daily.Custom_Control;

namespace Daily.Forms
{
    public partial class MainForm : Form
    {
        //int panelWidth;
        //bool Hidden;
        bool flag;   //窗口隐藏与否
        public MainForm()
        {
            InitializeComponent();
            
            panelFollow.Left = buttonCalendar.Left;
            //panelWidth = panelLeft.Width;
            //Hidden = true;
            flag = false;
        }
        
        //给窗口加阴影
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyIconTray.BalloonTipTitle = "Time Master";
            notifyIconTray.BalloonTipText = "Hello!";
            notifyIconTray.Visible = true;
            
        }

        private void circularButtonExit_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            dialog.StartPosition = FormStartPosition.CenterParent;

            dialog.Owner = this;
            dialog.ShowDialog();
            
        }



        private void circularButtonMinus_Click_1(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void circularButtonTheme_Click(object sender, EventArgs e)
        {

        }

        private void circularButtonDown_Click(object sender, EventArgs e)
        {

        }

        private void user1_Load(object sender, EventArgs e)
        {

        }

        

       
   
        private void notifyIconTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag && e.Button == MouseButtons.Left)
            {
                this.Show();
            }
            
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void sHOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            
            Setting setting = new Setting();
            setting.StartPosition = FormStartPosition.CenterParent;
            setting.Owner = this;
            setting.ShowDialog();
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            
            Help help = new Help();
            help.StartPosition = FormStartPosition.CenterParent;
            help.ShowDialog();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelFollow.Left = buttonHome.Left;
            homePage.Show();
            homePage.BringToFront();
            timerDown.Start();
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            if (homePage.Height < 520)
            {
                homePage.Height = homePage.Height + 26;
            }
            else
            {
                timerDown.Stop();
            }
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            panelFollow.Left = buttonCalendar.Left;
            CalendarPage calendarPage = new CalendarPage();
            calendarPage.Location = new Point(0, 35);
            this.Controls.Add(calendarPage);

            calendarPage.BringToFront();
        }

        private void buttonTaskView_Click(object sender, EventArgs e)
        {

            panelFollow.Left = buttonTaskView.Left;
            TaskViewPage taskViewPage = new TaskViewPage();
            taskViewPage.Location = new Point(0, 35);
            this.Controls.Add(taskViewPage);
            taskViewPage.BringToFront();
        }
    }
}
