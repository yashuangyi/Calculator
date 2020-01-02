using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ExperimentFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SkinButton2_Click(object sender, EventArgs e)//数字键事件汇总1~9
        {
            if (Store.isCalculate || Store.clear)//上一个操作若为运算符或等于号则清空屏幕
            {
                screen.Text = "";
                Store.clear = false;
            }
            if (screen.Text == "0")//如果只有一个0则先清空
                screen.Text = "";
            if(sender is Button)//事件共享
            {
                Button btn = (Button)sender;
                screen.Text += btn.Text;
            }
            else
            {

            }
            Store.isCalculate = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎使用刀仔的第一个基于C#语言开发的窗口程序~\n" +
                "本计算器功能与系统自带计算器功能相仿\n" +
                "同时支持快捷键~\n"+
                "若有疑惑或建议欢迎投至邮箱:940572396@qq.com\n" +
                "谢谢(˶˚  ᗨ ˚˶)", "说明",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {

        }

        private void SkinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            if (Store.isCalculate||Store.clear)
            {
                screen.Text = "";
                Store.clear = false;
            }
            if (screen.Text != "0")
            {
                screen.Text += "0";
            }
            Store.isCalculate = false;
        }

        private void Btn_dot_Click(object sender, EventArgs e)
        {
            if (!screen.Text.Contains("."))
            {
                screen.Text += ".";
                Store.isCalculate = false;
                Store.clear = false;
            }
        }

        private void Btn_backspace_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                screen.Text = screen.Text.Remove(screen.Text.Length-1);
                if (screen.Text == "")
                {
                    screen.Text = "0";
                }
            }
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            Store.result = 0;
            sign.Text = "";
            Store.isCalculate = false;
        }

        private void Btn_CE_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void Btn_MS_Click(object sender, EventArgs e)
        {
            if (screen.Text[screen.Text.Length - 1] != '.')
            {
                Store.memory = double.Parse(screen.Text);
                if (Store.memory != 0)
                {
                    isM.Checked = true;
                }
            }
        }

        private void Btn_MR_Click(object sender, EventArgs e)
        {
            if (isM.Checked)
            {
                screen.Text = Store.memory.ToString();
                Store.isCalculate = false;
            }
        }

        private void Btn_MC_Click(object sender, EventArgs e)
        {
            isM.Checked = false;
        }

        private void Btn_Mplus_Click(object sender, EventArgs e)
        {
            if (isM.Checked)
            {
                screen.Text = (Store.memory+double.Parse(screen.Text)).ToString();
                Store.isCalculate = false;
            }
        }

        private void Btn_neg_Click(object sender, EventArgs e)
        {
            if (screen.Text.Contains("-"))
            {
                screen.Text = screen.Text.Replace("-","");
            }
            else
            {
                if (screen.Text != "0")
                {
                    screen.Text = "-" + screen.Text;
                }
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)//运算符汇总
        {
            if (!Store.isCalculate)//如果上一个不是运算符则计算出结果，以保证可以连续运算
            {
                Btn_equal_Click(null, e);
                Store.clear = false;
            }
            if (sign.Text == "")//如果之前没有运算符，则保存当前屏幕的数字以待运算
                Store.result = double.Parse(screen.Text);
            if(sender is Button)
            {
                Button btn = sender as Button;
                sign.Text = btn.Text;//呈现出运算符
            }
            Store.isCalculate = true;
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            if (!Store.isCalculate)
            {
                Btn_equal_Click(sender, e);
                Store.clear = false;
            }
            if (screen.Text.Contains('.'))
            {
                screen.Text = "Error";
                Thread thread = new Thread(new ThreadStart(Error));
                thread.Start();
                thread.Join();
                Btn_C_Click(sender, e);
            }
            if (sign.Text == "")
                Store.result = double.Parse(screen.Text);
            sign.Text = "%";
            Store.isCalculate = true;
        }

        private void Btn_rec_Click(object sender, EventArgs e)
        {
            if(screen.Text == "0")//0没有倒数，报错并初始化
            {
                screen.Text = "Error";
                Thread thread = new Thread(new ThreadStart(Error));
                thread.Start();
                thread.Join();
                Btn_C_Click(sender,e);
            }
            else if (screen.Text[screen.Text.Length-1]!='.')//不允许只有小数点在末尾
            {
                screen.Text = (1.0/double.Parse(screen.Text)).ToString();
            }
        }

        private void SkinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_sqrt_Click(object sender, EventArgs e)
        {
            if (screen.Text[0] == '-')
            {
                screen.Text = "Error";
                Thread thread = new Thread(new ThreadStart(Error));
                thread.Start();
                thread.Join();
                Btn_C_Click(sender, e);
            }
            else
            {
                screen.Text = System.Math.Sqrt(double.Parse(screen.Text)).ToString();
            }
        }

        private void Error()
        {
            Thread.Sleep(3000);
        }

        private void Btn_equal_Click(object sender, EventArgs e)
        {
            switch(sign.Text)
            {
                case "+":
                    Store.result += double.Parse(screen.Text);
                    screen.Text = Store.result.ToString();
                    Store.isCalculate = false;
                    Store.clear = true;
                    sign.Text = "";
                    break;
                case "-":
                    Store.result -= double.Parse(screen.Text);
                    screen.Text = Store.result.ToString();
                    Store.isCalculate = false;
                    Store.clear = true;
                    sign.Text = "";
                    break;
                case "*":
                    Store.result *= double.Parse(screen.Text);
                    screen.Text = Store.result.ToString();
                    Store.isCalculate = false;
                    Store.clear = true;
                    sign.Text = "";
                    break;
                case "/":
                    if (screen.Text.Contains('.') || screen.Text == "0")
                    {
                        screen.Text = "Error";
                        Thread thread = new Thread(new ThreadStart(Error));
                        thread.Start();
                        thread.Join();
                        Btn_C_Click(sender, e);
                    }
                    else
                    {
                        Store.result /= double.Parse(screen.Text);
                        screen.Text = Store.result.ToString();
                        Store.isCalculate = false;
                        Store.clear = true;
                        sign.Text = "";
                    }
                    break;
                case "%":
                    if (screen.Text.Contains('.')||screen.Text=="0")
                    {
                        screen.Text = "Error";
                        Thread thread = new Thread(new ThreadStart(Error));
                        thread.Start();
                        thread.Join();
                        Btn_C_Click(sender, e);
                    }
                    else
                    {
                        Store.result = (int)Store.result % int.Parse(screen.Text);
                        screen.Text = Store.result.ToString();
                        Store.isCalculate = false;
                        Store.clear = true;
                        sign.Text = "";
                    }
                    break;
            }
        }

        private void Key_press(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0||e.KeyCode==Keys.NumPad0)
            {
                Btn_0_Click(null, null);
            }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                SkinButton2_Click(btn_1, null);
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                SkinButton2_Click(btn_2, null);
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                SkinButton2_Click(btn_3, null);
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                SkinButton2_Click(btn_4, null);
            }
            if (!e.Shift&(e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5))
            {
                SkinButton2_Click(btn_5, null);
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                SkinButton2_Click(btn_6, null);
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                SkinButton2_Click(btn_7, null);
            }
            if (!e.Shift&(e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8))
            {
                SkinButton2_Click(btn_8, null);
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                SkinButton2_Click(btn_9, null);
            }
            if (e.Shift&e.KeyValue == 187)
            {
                Btn_add_Click(btn_add, null);
            }
            if (!e.Shift & e.KeyValue == 189)
            {
                Btn_add_Click(btn_sub, null);
            }
            if (e.Shift & e.KeyCode == Keys.D8)
            {
                Btn_add_Click(btn_mul, null);
            }
            if (e.KeyCode == Keys.C)
            {
                Btn_close_Click(null, null);
            }
            if (e.KeyCode == Keys.H)
            {
                Btn_help_Click(null, null);
            }
            if (e.KeyValue == 8)
            {
                Btn_backspace_Click(null, null);
            }
            if (e.KeyValue == 191)
            {
                Btn_add_Click(btn_div, null);
            }
            if (e.Shift & e.KeyCode == Keys.D5)
            {
                Btn_mod_Click(null, null);
            }
            if (!e.Shift & e.KeyValue == 187)
            {
                Btn_equal_Click(null, null);
            }
        }
    }

    public class Store//计算器的寄存器
    {
        public static double result = 0;//运算结果
        public static double memory = 0;//存储器存储的数字
        public static Boolean isCalculate = false;//上一个输入的是否为运算符
        public static Boolean clear = false;//单独处理“=”之后直接输入数字，视为清零操作
    }
}
