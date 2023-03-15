using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Nt106
{
    public partial class Bài_1 : Form
    {
        public Bài_1()
        {
            InitializeComponent();
        }
        public bool Kt_thong_tin(string arr)
        {
            foreach(char value in arr)
            {
                try
                {
                    int number = Convert.ToInt32(arr);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập lại số nguyên");
                    return false;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Tràn số vui lòng nhập lại số nguyên");
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if(Kt_thong_tin(textBox1.Text)&&Kt_thong_tin(textBox2.Text)) 
            {
                num1 = Int32.Parse(textBox1.Text);
                num2 = Int32.Parse(textBox2.Text);
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
        }
    }
}
