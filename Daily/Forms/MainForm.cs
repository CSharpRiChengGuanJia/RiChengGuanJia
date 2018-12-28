using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            dialog.hide += new Dialog.EventForm(() =>
            {
                this.Hide();
                flag = true;
            });
            dialog.notifyDispose += new Dialog.EventForm(() => notifyIconTray.Dispose());
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

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timerPanelLeft.Start();
        }

        //private void timerPanelLeft_Tick(object sender, EventArgs e)
        //{
        //    if (Hidden)
        //    {
        //        panelLeft.Width = panelLeft.Width + 7;
        //        if (panelLeft.Width >= 230)
        //        {
        //            timerPanelLeft.Stop();
        //            Hidden = false;
        //            this.Refresh();
        //        }
        //    }
        //    else
        //    {
        //        panelLeft.Width = panelLeft.Width - 7;
        //        if(panelLeft.Width <= panelWidth)
        //        {
        //            timerPanelLeft.Stop();
        //            Hidden = true;
        //            this.Refresh();
        //        }
        //    }
        //}

        //private void buttonHome_Click(object sender, EventArgs e)
        //{
        //    panelFollow.Top = buttonHome.Top;
        //    buttonHome.BackColor = Color.FromArgb(115, 115, 255);
        //    buttonHome.ForeColor = Color.WhiteSmoke;
        //    buttonCal.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonCal.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonHelp.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonHelp.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonSetting.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonSetting.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonTask.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonTask.ForeColor = Color.FromArgb(50, 180, 192);
        //}

        //private void buttonCal_Click(object sender, EventArgs e)
        //{
        //    panelFollow.Top = buttonCal.Top;
        //    buttonCal.BackColor = Color.FromArgb(115, 115, 255);
        //    buttonCal.ForeColor = Color.WhiteSmoke;
        //    buttonHome.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonHome.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonHelp.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonHelp.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonSetting.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonSetting.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonTask.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonTask.ForeColor = Color.FromArgb(50, 180, 192);
        //}

        //private void buttonTask_Click(object sender, EventArgs e)
        //{
        //    panelFollow.Top = buttonTask.Top;
        //    buttonTask.BackColor = Color.FromArgb(115, 115, 255);
        //    buttonTask.ForeColor = Color.WhiteSmoke;
        //    buttonHome.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonHome.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonCal.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonCal.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonHelp.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonHelp.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonSetting.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonSetting.ForeColor = Color.FromArgb(50, 180, 192);
        //}

        //private void buttonHelp_Click(object sender, EventArgs e)
        //{
        //    panelFollow.Top = buttonHelp.Top;
        //    buttonHelp.BackColor = Color.FromArgb(115, 115, 255);
        //    buttonHelp.ForeColor = Color.WhiteSmoke;
        //    buttonHome.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonHome.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonCal.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonCal.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonSetting.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonSetting.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonTask.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonTask.ForeColor = Color.FromArgb(50, 180, 192);
        //}

        //private void buttonSetting_Click(object sender, EventArgs e)
        //{
        //    panelFollow.Top = buttonSetting.Top;
        //    buttonSetting.BackColor = Color.FromArgb(115, 115, 255);
        //    buttonSetting.ForeColor = Color.WhiteSmoke;
        //    buttonHome.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonHome.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonCal.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonCal.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonHelp.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonHelp.ForeColor = Color.FromArgb(50, 180, 192);
        //    buttonTask.BackColor = Color.FromArgb(41, 45, 52);
        //    buttonTask.ForeColor = Color.FromArgb(50, 180, 192);
        //}

   
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
    }
}
