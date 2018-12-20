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
    public partial class Form1 : Form
    {
        //public GlobalVariable Global = new GlobalVariable();

        public Form1()
        {
            InitializeComponent();
            GlobalVariable.TestInit(); //先随便初始化几个事务，用来测试
            bindingSource1.DataSource = GlobalVariable.AllWorks; //暂时把首页数据绑定为全部事务
        }
    }
}
