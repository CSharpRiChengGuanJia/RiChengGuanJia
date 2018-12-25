using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily.Custom_Control
{
    public partial class Month : UserControl
    {
        public override string Text
        {
            get
            {
                return label.Text;
            }
            set
            {
                label.Text = value;

            }
        }
        private DateTime date = DateTime.Now;
        public Month()
        {
            InitializeComponent();
            label.BackColor = Color.FromArgb(0, 50, 50, 50);
            this.BackColor = Color.FromArgb(0, Color.Black);
            //if (mouseClicked == false)
            //{
            //    this.BackColor = Color.FromArgb(0, Color.Black);
            //}
        }
        //public bool mouseClicked = false;
        private void label_Click(object sender, EventArgs e)
        {
            //mouseClicked = true;
            OnClick(e);
        }

        private void Month_MouseEnter(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.Text);
            if (i != date.Month)
               
                    this.BackColor = Color.FromArgb(75, Color.Black);
        }

        private void Month_MouseLeave(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.Text);
            if(i != date.Month)
                
                    this.BackColor = Color.FromArgb(0, Color.Black);
           
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.Text);
            if (i != date.Month)
                
                    this.BackColor = Color.FromArgb(75, Color.Black);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.Text);
            if (i != date.Month)
                this.BackColor = Color.FromArgb(0, Color.Black);
            

            
        }
        
        private void Month_Click(object sender, EventArgs e)
        {
            CalendarPage calendar = (CalendarPage)this.Parent.Parent;
            CalendarPage.chosenMonth = Convert.ToInt32(this.Text);
            //this.BackColor = Color.FromArgb(120, Color.Orange);
            //calendar.DisplayMonth();
            calendar.DisplayDay(date);
            
            //Change(date);
        }
    }
}
