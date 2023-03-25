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
    public partial class Bài_2 : Form
    {
        public Bài_2()
        {
            InitializeComponent();
        }
        public string Tim_max(string arr1,string arr2,string arr3)
        {
            int max = Int32.Parse(arr1);
            if(max < Int32.Parse(arr2)) 
                max= Int32.Parse(arr2);
            if (max < Int32.Parse(arr3))
              max = Int32.Parse(arr3);
            return max.ToString();
        }
        public string Tim_min(string arr1, string arr2, string arr3)
        {
            int min = Int32.Parse(arr1);
            if (min > Int32.Parse(arr2))
                min = Int32.Parse(arr2);
            if (min > Int32.Parse(arr3))
                min = Int32.Parse(arr3);
            return min.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = Tim_max(textBox1.Text, textBox2.Text, textBox3.Text);
            textBox5.Text = Tim_min(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
