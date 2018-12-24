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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void circularButtonLogin_Click(object sender, EventArgs e)
        {
            
            //string username = "1";
            //string password = "1";
            //try
            //{
            //    if (username == this.textBoxUser.Text && password == this.textBoxPass.Text)
            //    {
                    MainForm form = new MainForm();
                    this.Hide();
                    form.Show();
                //}
            //}catch(Exception ex)
            //{
            //    MessageBox.Show("请确保已输入用户名和密码！");
            //}
            
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.Clear();
            textBoxUser.ForeColor = Color.FromArgb(192, 255, 255);
            textBoxPass.ForeColor = Color.Gray;
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.Clear();
            textBoxPass.ForeColor = Color.FromArgb(192, 255, 255);
            textBoxUser.ForeColor = Color.Gray;
        }
    }
}
