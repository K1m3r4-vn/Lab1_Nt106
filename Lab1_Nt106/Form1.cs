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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bài_4 B4 = new Bài_4();
            B4.ShowDialog();
        }

        private void Bài1_Click(object sender, EventArgs e)
        {
            Bài_1 B1 = new Bài_1();
            B1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bài_2 B2 = new Bài_2();
            B2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bài_3 B3=new Bài_3();
            B3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bài_5 B5 = new Bài_5();
            B5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bài_6 B6 = new Bài_6();
            B6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bài_8 B8 = new Bài_8();
            B8.ShowDialog();
        }
    }
}
