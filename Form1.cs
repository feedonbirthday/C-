using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20180716A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //A =學號分別為101 102 103 104 105
        int A = 0;
        int[] S = new int[15] { 101, 102, 103, 104, 105 ,106 ,107,108,109,110,111,112,113,114,115};
        int[] C = new int[15] { 80, 89, 95, 76, 60,80,75,77,90,10,50,55,40,22,67 };  //國文
        int[] E = new int[15] { 66, 65, 100, 89, 62,80,88,89,77,16,25,33,40,60,63 }; //英文
        int[] M = new int[15] { 70, 62, 88, 85, 83,100,50,60,66,77,51,33,86,84,15 }; //數學
        string[] N = new string[15] { "小名", "小偉", "曉華", "小翰", "志明","曉明","小鎂","阿緯","小巴","家家","永慶","小齊","婷婷","菲哥","魚哥" };
        int temp;
        string output = "";
        string output1 = "";
        string output2 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= 14; i++)
            {
                if (A == S[i])
                {

                    int sum;
                    int average;
                    string student;
                    student = N[i];
                    sum = C[i] + E[i] + M[i];
                    average = sum / 3;
                    label1.Text = "姓名：" + student + "\r\n" + "總分：" + sum + "分" + "\r\n" + "平均：" + average + "分";

                }
                /*else
                {
                    MessageBox.Show("無法操作", "不是規定值", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

            }

            /*else if (A == S[1])
            {

                int sum;
                int average;
                string student;
                student = N[1];
                sum = C[1] + E[1] + M[1];
                average = sum / 3;
                label1.Text = "姓名：" + student + "\r\n" + "總分：" + sum + "分" + "\r\n" + "平均：" + average + "分";

            }
            else if (A == S[2])
            {

                int sum;
                int average;
                string student;
                student = N[2];
                sum = C[2] + E[2] + M[2];
                average = sum / 3;
                label1.Text = "姓名：" + student + "\r\n" + "總分：" + sum + "分" + "\r\n" + "平均：" + average + "分";

            }
            else if (A == S[3])
            {

                int sum;
                int average;
                string student;
                student = N[3];
                sum = C[3] + E[3] + M[3];
                average = sum / 3;
                label1.Text = "姓名：" + student + "\r\n" + "總分：" + sum + "分" + "\r\n" + "平均：" + average + "分";

            }
            else if (A == S[4])
            {

                int sum;
                int average;
                string student;
                student = N[4];
                sum = C[4] + E[4] + M[4];
                average = sum / 3;
                label1.Text = "姓名：" + student + "\r\n" + "總分：" + sum + "分" + "\r\n" + "平均：" + average + "分";

            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            output = label3.Text;
            output1 = label3.Text;
            output2 = label3.Text;
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = i; j < C.Length; j++)
                {
                    if (C[i] > C[j])
                    {
                        temp = C[j];
                        C[j] = C[i];
                        C[i] = temp;
                    }
                }
            }
            for (int b = 0; b < C.Length; b++)
            {
                output = C[b] + "\n";
                label3.Text = output;

            }
            for (int i = 0; i < E.Length; i++)
            {
                for (int j = i; j < E.Length; j++)
                {
                    if (E[i] > E[j])
                    {
                        temp = E[j];
                        E[j] = E[i];
                        E[i] = temp;
                    }
                }
            }
            for (int c = 0; c < E.Length; c++)
            {
                output1 = E[c] + "\n";


            }
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = i; j < M.Length; j++)
                {
                    if (M[i] > M[j])
                    {
                        temp = M[j];
                        M[j] = M[i];
                        M[i] = temp;
                    }
                }
            }
            for (int d = 0; d < M.Length; d++)
            {
                output2 = M[d] + "\n";


            }
            label3.Text = "國文最高分：" + output + "\r\n" + "英文最高分：" + output1 + "\r\n" + "數學最高分：" + output2 + "\r\n";
        }
    }
}
