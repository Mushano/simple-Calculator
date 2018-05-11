using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + " " + btn.Text + "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + " " + btn.Text + " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + " " + btn.Text + " ";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + " " + btn.Text + " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Single r;//用于保存计算结果
            string t = textBox1.Text;//t用于保存文本框中的算数表达式
            int space = t.IndexOf(' ');//用于搜索空格位置
            string s1 = t.Substring(0, space);//s1用于保存第一个运算数
            char op = Convert.ToChar(t.Substring(space + 1, 1));
            //op 用于保存运算符
            string s2 = t.Substring(space + 3);//s2用于保存第二个运算数
            Single arg1 = Convert.ToSingle(s1);
            //将运算数从string 转换为Single
            Single arg2 = Convert.ToSingle(s2);
            switch (op)
            {
                case '+':
                    r = arg1 + arg2;
                    break;
                case '-':
                    r = arg1 - arg2;
                    break;
                case '*':
                    r = arg1 * arg2;
                    break;
                case '/':
                    if (arg2 == 0)
                    {
                        throw new ApplicationException();
                    }
                    else
                    {
                        r = arg1 / arg2;
                        break;
                    }
                    break;
                default:
                    throw new ApplicationException();
            }
            textBox1.Text = r.ToString();
        }
    }
}
