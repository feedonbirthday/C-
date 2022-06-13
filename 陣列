using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20180712A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //陣列
            //Money = 兌換金額 A=50 B=20 C=10 D=5 E=1
            int Money =0;
            Money = Convert.ToInt32(textBox1.Text);
            int[] coin =new int[5]{ 50,20,10,5,1};
            int []change = new int[5] { 0, 0, 0, 0, 0 };
            if (checkBox1.Checked )
            {
                change[0] = Money / coin[0];
                Money = Money % coin[0];
                
            }
            if (checkBox2.Checked)
            {
                change[1] = Money / coin[1];
                Money = Money % coin[1];
                
            }
            if (checkBox3.Checked)
            {
                change[2] = Money / coin[2];
                Money = Money % coin[2];
            }
            if (checkBox4.Checked)
            {
                change[3] = Money / coin[3];
                Money = Money % coin[3];
            }
            if (checkBox5.Checked)
            {
                change[4] = Money;
            }
            textBox2.Text = change[0].ToString();
            textBox3.Text = change[1].ToString();
            textBox4.Text = change[2].ToString();
            textBox5.Text = change[3].ToString();
            textBox6.Text = change[4].ToString();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
