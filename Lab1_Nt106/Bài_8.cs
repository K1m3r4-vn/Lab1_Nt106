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
    public partial class Bài_8 : Form
    {
        public Bài_8()
        {
            InitializeComponent();
        }
        public Boolean String_split()
        {
            
            String[] strlist = String_In.Text.Split(new string[] {", ",","," ,"}, StringSplitOptions.None);
            if (strlist[0].All(Char.IsLetter))
            {
                String_Out.Text="Ho va ten: " + strlist[0]+Environment.NewLine;
                for (int i = 1; i < strlist.Length; i++)
                {
                    if (strlist[i].All(Char.IsDigit) && Convert.ToDouble(strlist[i]) >= 0 && Convert.ToDouble(strlist[i]) <= 10)
                    {
                        String_Out.Text += "Mon " + i + " : " + strlist[i] + Environment.NewLine;
                    }
                    else
                    {
                        MessageBox.Show("Nhap lai so");
                        String_Out.Clear();
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhap lai ten");
                String_In.Clear();
                String_Out.Clear();
            }
            return true;
        }
        private void String_Out_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            String_split();
        }
    }
}
