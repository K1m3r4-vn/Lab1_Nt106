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
    public partial class Bài_3 : Form
    {
        public Bài_3()
        {
            InitializeComponent();
        }
        public void Num_read(string arr)
        {
            switch(Int32.Parse(arr))
            {
                case 0:
                    Read.Text = "Không";
                    break;
                case 1:
                    Read.Text = "Một";
                    break;
                case 2:
                    Read.Text = "Hai";
                    break;
                case 3:
                    Read.Text = "Ba";
                    break;
                case 4:
                    Read.Text = "Bốn";
                    break;
                case 5:
                    Read.Text = "Năm";
                    break;
                case 6:
                    Read.Text = "Sáu";
                    break;
                case 7:
                    Read.Text = "Bảy";
                    break;
                case 8:
                    Read.Text = "Tám";
                    break;
                case 9:
                    Read.Text = "Chín";
                    break;
            }
        }
        private void ReadN_Click(object sender, EventArgs e)
        {
            Num_read(ReadNum.Text);
        }

        private void Del_Click(object sender, EventArgs e)
        {
            ReadNum.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
