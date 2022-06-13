using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20180726_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int A = 0;
        int B, C, D, E, F, G, H, I, J, K;
        int b, c, C1, C2, f, g, h, i1, j1, k;
        private void button1_Click(object sender, EventArgs e)
        {
            int[] N = new int[11] { 3, 4, 7, 8, 10, 2, 5, 1, 3, 2, 1 };
            B = N[0] + N[1] + N[2]; C = B + N[3]; D = C + N[4]; E = D + N[5];
            F = E + N[6]; G = F + N[7]; H = G + N[8]; I = H + N[9]; J = I + N[10];
            K = J + N[11]; b = N[11] + N[10] + N[9]; c = b + N[8]; C1 = c + N[7];
            C2 = C1 + N[6]; f = C2 + N[5];
            g = f + N[4]; h = g + N[3]; i1 = h + N[2];
            j1 = i1 + N[1]; k = j1 + N[0];
            int i,j;
            for (i = 0; i < 11; i++)
            {
                for (j = 11; j <= 0; j--)
                {
                    while (N[i] + N[i + 1] == N[j - i] + N[j - (i + 1)])
                    {
                        A++;
                        label1.Text += " 總共有： " + A;
                    }
                    if (N[i] + N[i + 1] > N[j - i] + N[j - (i + 1)])
                    {
                        if (N[i] + N[i + 1] == b)
                        {
                            A++;
                            label1.Text += " 總共有： " + A;
                        }
                        break;
                    }
                }
               
            }
        }
    }
}
