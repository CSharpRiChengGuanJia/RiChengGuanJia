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
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
            
        }
        private const int CS_DropShadow = 0x00020000;
        public delegate void EventForm();
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)this.Owner;
            form.notifyIconTray.Dispose();
            this.Dispose();
            Environment.Exit(0);
           
            
            
           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            this.Close();
        }

        private void buttonTray_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)this.Owner;
            form.Hide();
            this.Dispose();
            this.Close();
          
           
        }
    }
}
