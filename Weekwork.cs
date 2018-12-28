using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily
{
    public partial class Weekwork : UserControl
    {
        public Weekwork()
        {
            InitializeComponent();
            
        }
        public void getworks(DailyEntity day)
        { 
            
            if (day != null)
            {
                int i = day.Works.Count();
                Detail[] details = new Detail[i];
                for (int j = 0; j < i; j++)
                {
                    TimeSpan t1 = new TimeSpan(day.works[j].StartTime.Ticks);
                    DateTime tt = new DateTime(day.works[j].StartTime.Year, day.works[j].StartTime.Month, day.works[j].StartTime.Day, 0, 0, 0);
                    TimeSpan t2 = new TimeSpan(tt.Ticks);
                    TimeSpan t3 = new TimeSpan(day.works[j].EndTime.Ticks);
                    TimeSpan t4 = t1.Subtract(t2);
                    TimeSpan t5 = t3.Subtract(t1);
                    int sum = (int)t4.TotalSeconds;
                    int length = (int)t5.TotalSeconds;
                    details[j] = new Detail();
                    details[j].Visible = true;
                    details[j].Text = day.works[j].WorkName;
                    details[j].Location = new System.Drawing.Point( 0, this.Height * sum / (24 * 3600));
                    details[j].Size = new System.Drawing.Size(this.Width, this.Height * length / 24 * 3600);
                    switch (day.works[j].Level)
                    {
                        case 5:
                            details[j].BackColor = Color.Green;
                            break;
                        case 1:
                            details[j].BackColor = Color.Yellow;
                            break;
                        case 3:
                            details[j].BackColor = Color.Red;
                            break;
                        default:
                            details[j].BackColor = Color.Black;
                            break;
                    }
                    this.Controls.Add(details[j]);
                }
            }
        }
    }
}
