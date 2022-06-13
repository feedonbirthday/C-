using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20180719_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int output1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            
            Random rd = new Random();
            int guess = rd.Next(0, 1000); //亂數
            int A;  //A =猜測的數值
            A = int.Parse(textBox1.Text);

            if (guess == A)
            {
                output = "答對了~" + "\r\n";
            }
            else if (guess > A)
            {
                output = "猜太小了" + "\r\n";
            }
            else if (guess <A)
            {
                output = "猜太大了" + "\r\n";
            }
            if (guess != A)
            {
                output1 ++;
                //output1 += "猜測次數 ： " ;
            }
            
            label2.Text = output +"\r\n" + "猜測次數 ： " + output1 + "\r\n" ;

        }
    }
}
