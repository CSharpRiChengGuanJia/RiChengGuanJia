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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        bool Checked = true;
        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

       

        private void AlarmCheck_Click(object sender, EventArgs e)
        {
            if(Checked == true)
            {
                AlarmCheck.Image = Image.FromFile(@"..\..\Resources\Unchecked.png");
                Checked = false;
            }
            else
            {
                AlarmCheck.Image = Image.FromFile(@"..\..\Resources\Checked.png");
                Checked = true;
            }
                

        }

        private void TrackBarOpacity_Scroll(object sender, EventArgs e)
        {
            this.Owner.Opacity = ((double)(TrackBarOpacity.Value) / 100.0);
           
        }
    }
}
