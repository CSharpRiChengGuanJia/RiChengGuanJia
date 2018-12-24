using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Daily.Forms;

namespace Daily.Custom_Control
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            ButtonAdd.BackColor = Color.FromArgb(50, Color.Black);
            ButtonTask.BackColor = Color.FromArgb(50, Color.Black);
            panel2.BackColor = Color.FromArgb(50, Color.Black);
            labelRecent.BackColor = Color.FromArgb(0, Color.Black);
            recentTask1.BackColor = Color.FromArgb(40, Color.Black);
            recentTask2.BackColor = Color.FromArgb(40, Color.Black);
            recentTask3.BackColor = Color.FromArgb(40, Color.Black);
        }
        
        private void pictureBoxWeather_Click(object sender, EventArgs e)
        {

        }
        private int xLocation = -205;
        private int dialogCenterX;
        private int dialogCenterY;
        private void HomePage_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            timerEffect.Start();
            
        
            recentTask1.Location = new Point(-205, 27);
            recentTask2.Location = new Point(-205, 77);
            recentTask3.Location = new Point(-205, 126);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            int secToMilli = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            labelHour.Text = DateTime.Now.ToString("HH");
            labelMin.Text = DateTime.Now.ToString("mm");
            labelDay.Text = DateTime.Now.ToString("dd");
            labelDate.Text = DateTime.Now.ToString("MMM yyyy\ndddd", new CultureInfo("en-us"));

          
            if (panelLeft.Width <= this.Width / 2)
            {
                panelLeft.Width = (this.Width / 2) * secToMilli / 60000;
                panelRight.Width = (this.Width / 2) * secToMilli / 60000;
                panelRight.Left = this.Width - panelRight.Width;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            timerUp.Start();
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {
            if(this.Height >= 0)
            {
            
                
                this.Height = this.Height - 26;
                this.Refresh();
                
            }
            else
            {
                timerUp.Stop();
                this.Hide();
            }
                
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTask_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            this.dialogCenterX = dialog.Width / 2;
            this.dialogCenterY = dialog.Height / 2;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog();
            
        }

       

        private void timerEffect_Tick(object sender, EventArgs e)
        {
            int yLocation = recentTask1.Location.Y;
            if (recentTask1.Location.X <= 0)
            {
                xLocation = xLocation + 5;
                if (xLocation <= 0)
                {
                    recentTask1.Location = new Point(xLocation, yLocation);
                    this.Refresh();
       
                }
                else
                {
                    timerEffect.Stop();
                    xLocation = -205;
                    timerEffect2.Start();
                }
            }
           
                
            
        }

        private void timerEffect2_Tick(object sender, EventArgs e)
        {
            int yLocation = recentTask2.Location.Y;
            if (recentTask1.Location.X <= 0)
            {
                xLocation = xLocation + 5;
                if (xLocation <= 0)
                {
                    
                    recentTask2.Location = new Point(xLocation, yLocation);
                    this.Refresh();

                }
                else
                {
                    timerEffect2.Stop();
                    xLocation = -205;
                    timerEffect3.Start();
                }
            }
        }

        private void timerEffect3_Tick(object sender, EventArgs e)
        {
            int yLocation = recentTask3.Location.Y;
            if (recentTask3.Location.X <= 0)
            {
                xLocation = xLocation + 5;
                if (xLocation <= 0)
                {
                    
                    recentTask3.Location = new Point(xLocation, yLocation);
                    this.Refresh();

                }
                else
                {
                    timerEffect3.Stop();
                    xLocation = -205;
                    
                }
            }
        }



       
    }
}
