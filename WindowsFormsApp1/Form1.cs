using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }

    

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //keypress 按下某键 
        {
            if (e.KeyChar == (char)Keys.Enter)//按下的是否回车键
            {
                //button1.PerformClick(); //按下button1
                button1_Click(null,null); //调用按下button1函数
                 e.Handled = true;               //加上这个，没有 "咚" 的一声响
            }
        }
    }
}
