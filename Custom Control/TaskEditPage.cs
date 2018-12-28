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
    public partial class TaskEditPage : UserControl
    {
        public TaskEditPage()
        {
            InitializeComponent();
            
        }
        private static string sStart = "9:00 AM";
        private static string sTitle = "Title";
        private static string sEnd = "9:00 PM";
        private static string sLocation = "Location";
        private static string sDetails = "Details";
        bool Checked1 = false;
        bool Checked2 = false;
        bool Checked3 = false;
        bool Checked4 = false;
        bool Checked5 = false;
       
        private void TaskEditPage_Load(object sender, EventArgs e)
        {
           
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            #region
            
            textBoxTitle.Clear();
            if (textBoxStart.Text == "")
                textBoxStart.Text = sStart;
            if (textBoxEnd.Text == "")
                textBoxEnd.Text = sEnd;
            if (textBoxLocation.Text == "")
                textBoxLocation.Text = sLocation;
            if (textBoxDetails.Text == "")
                textBoxDetails.Text = sDetails;
            #endregion
        }

        private void textBoxStart_Click(object sender, EventArgs e)
        {
            #region
            
            textBoxStart.Clear();
            if (textBoxTitle.Text == "")
                textBoxTitle.Text = sTitle;
            if (textBoxEnd.Text == "")
                textBoxEnd.Text = sEnd;
            if (textBoxLocation.Text == "")
                textBoxLocation.Text = sLocation;
            if (textBoxDetails.Text == "")
                textBoxDetails.Text = sDetails;
            #endregion
            
        }

        private void textBoxEnd_Click(object sender, EventArgs e)
        {
            #region
            
            textBoxEnd.Clear();
            if (textBoxTitle.Text == "")
                textBoxTitle.Text = sTitle;
            if (textBoxStart.Text == "")
                textBoxStart.Text = sStart;
            if (textBoxLocation.Text == "")
                textBoxLocation.Text = sLocation;
            if (textBoxDetails.Text == "")
                textBoxDetails.Text = sDetails;
            #endregion
            
            
        }

        private void textBoxLocation_Click(object sender, EventArgs e)
        {
            #region
           
            textBoxEnd.Clear();
            if (textBoxTitle.Text == "")
                textBoxTitle.Text = sTitle;
            if (textBoxStart.Text == "")
                textBoxStart.Text = sStart;
            if (textBoxEnd.Text == "")
                textBoxEnd.Text = sEnd;
            if (textBoxDetails.Text == "")
                textBoxDetails.Text = sDetails;
            #endregion
            textBoxLocation.Clear();
        }

        private void textBoxDetails_Click(object sender, EventArgs e)
        {
            #region
           
            textBoxDetails.Clear();
            if (textBoxTitle.Text == "")
                textBoxTitle.Text = sTitle;
            if (textBoxStart.Text == "")
                textBoxStart.Text = sStart;
            if (textBoxLocation.Text == "")
                textBoxLocation.Text = sLocation;
            if (textBoxEnd.Text == "")
                textBoxEnd.Text = sEnd;
            #endregion

        }

        private void AllDay_Click(object sender, EventArgs e)
        {
            if(Checked1 == false)
            {
                AllDay.Image = Image.FromFile( @"..\..\Resources\Checked.png");
                Checked1 = true;
            }
            else
            {
                AllDay.Image = Image.FromFile(@"..\..\Resources\Unchecked.png");
                Checked1 = false;
            }
        }

        private void Birthday_Click(object sender, EventArgs e)
        {
            if (Checked2 == false)
            {
                Birthday.Image = Image.FromFile(@"..\..\Resources\Checked.png");
                Checked2 = true;
            }
            else
            {
                Birthday.Image = Image.FromFile(@"..\..\Resources\Unchecked.png");
                Checked2 = false;
            }
        }

        private void Anniversary_Click(object sender, EventArgs e)
        {
            if (Checked3 == false)
            {
                Anniversary.Image = Image.FromFile(@"..\..\Resources\Checked.png");
                Checked3 = true;
            }
            else
            {
                Anniversary.Image = Image.FromFile(@"..\..\Resources\Unchecked.png");
                Checked3 = false;
            }
        }

    

        private void Else_Click(object sender, EventArgs e)
        {
            if (Checked5 == false)
            {
                Else.Image = Image.FromFile(@"..\..\Resources\Checked.png");
                Checked5 = true;
            }
            else
            {
                Else.Image = Image.FromFile(@"..\..\Resources\Unchecked.png");
                Checked5 = false;
            }
        }

        private void Graduation_Click(object sender, EventArgs e)
        {
            if (Checked4 == false)
            {
                Graduation.Image = Image.FromFile(@"..\..\Resources\Checked.png");
                Checked4 = true;
            }
            else
            {
                Graduation.Image = Image.FromFile(@"..\..\Resources\Unchecked.png");
                Checked4 = false;
            }
        }

        private void Anniversary_Click_1(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
