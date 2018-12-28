using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public Form10(WorkEntity we):this()
        {
            label2.Text = we.WorkName;
            richTextBox1.Text = we.Content;
            label5.Text = we.Level.ToString();
            label7.Text = we.StartTime.ToString();
        }
    }
}
