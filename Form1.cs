using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20180712__homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //A =學號分別為101 102 103 104 105
            int A = 0;
            A = Convert.ToInt32(textBox1.Text);
            int[] S = new int[5] { 101, 102, 103, 104, 105 };
            int[] C = new int[5] { 80, 89, 60, 76, 95 };
            int[] E = new int[5] { 60, 65, 80, 80, 100 };
            int[] M = new int[5] { 70, 77, 88, 85, 90 };
            if (A == S[0] )
            {
                textBox2.Text = C[0].ToString();
                textBox3.Text = E[0].ToString();
                textBox4.Text = M[0].ToString();
                int sum;
                sum =  C[0] + E[0] + M[0];
                textBox5.Text = + sum + "分";
                textBox6.Text = +sum / 3.0 + "分";
            }
            if (A == S[1])
            {
                textBox2.Text = C[1].ToString();
                textBox3.Text = E[1].ToString();
                textBox4.Text = M[1].ToString();
                int sum;
                sum = C[1] + E[1] + M[1];
                textBox5.Text = +sum + "分";
                textBox6.Text = +sum / 3.0 + "分";
            }
            if (A == S[2])
            {
                textBox2.Text = C[2].ToString();
                textBox3.Text = E[2].ToString();
                textBox4.Text = M[2].ToString();
                int sum;
                sum = C[2] + E[2] + M[2];
                textBox5.Text = +sum + "分";
                textBox6.Text = +sum / 3.0 + "分";
            }
            if (A == S[3])
            {
                textBox2.Text = C[3].ToString();
                textBox3.Text = E[3].ToString();
                textBox4.Text = M[3].ToString();
                int sum;
                sum = C[3] + E[3] + M[3];
                textBox5.Text = +sum + "分";
                textBox6.Text = +sum / 3.0 + "分";
            }
            if (A == S[4])
            {
                textBox2.Text = C[4].ToString();
                textBox3.Text = E[4].ToString();
                textBox4.Text = M[4].ToString();
                int sum;
                sum = C[4] + E[4] + M[4];
                textBox5.Text = +sum + "分";
                textBox6.Text = +sum / 3.0 + "分";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
