using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Nt106
{
    public partial class Bài_5 : Form
    {
        public Bài_5()
        {
            InitializeComponent();
        }
        public int Fac(int a)
        {
            int fac = 1;
            for(int i=1;i<=a;i++)
            {
                fac *= i;
            }
            return fac;
        }
        public int Sum(int a)
        {
            int sum = 0;
            for (int i = 1; i <= a; i++)
                sum += i;
            return sum;
        }
        public double AandB(int a,int b) 
        {
            double sum = 0;
            for (int i = 1; i <= b; i++)
                sum += Math.Pow(a, i);
            return sum;
        }
        public void Math_A(string arr1,string arr2)
        {
            int a=Int32.Parse(arr1);
            int b=Int32.Parse(arr2);
            textBox3.Text = "A! = " + Fac(a) + "\t"
                + " B! = " + Fac(b) + Environment.NewLine
                + " S1 = 1 + 2 + 3 + 4 + ... + A = " + Sum(a) + Environment.NewLine
                + " S2 = 1 + 2 + 3 + 4 + ... + B = " + Sum(b) + Environment.NewLine
                + " S3 = A^1 + A^2 + A^3 + ... + A^B =" + AandB(a, b) + Environment.NewLine;
        }
        private void TinhToan_Click(object sender, EventArgs e)
        {
            Math_A(textBox1.Text,textBox2.Text);
        }
    }
}
