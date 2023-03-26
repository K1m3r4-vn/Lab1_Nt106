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
    public partial class Bài_6 : Form
    {
        public Bài_6()
        {
            InitializeComponent();
        }
        public string Zoodiac(string arr)
        {
            DateTime a= DateTime.Parse(arr);
            string Zoo = "";
            switch(a.Month) 
            {
                case 1:
                    if (a.Day >= 1 && a.Day <= 20) Zoo = "Ma kết";
                    else Zoo = "Bảo Bình";
                    break;
                case 2:
                    if (a.Day >= 1 && a.Day <= 19) Zoo = "Bảo Bình";
                    else Zoo = "Song ngư";
                    break;
                case 3:
                    if (a.Day >= 1 && a.Day <= 20) Zoo = "Song ngư";
                    else Zoo = "Bạch Dương";
                    break;
                case 4:
                    if (a.Day >= 1 && a.Day <= 20) Zoo = "Bạch Dương";
                    else Zoo = "Kim Ngưu";
                    break;
                case 5:
                    if (a.Day >= 1 && a.Day <= 21) Zoo = "Kim Ngưu";
                    else Zoo = "Song Tử";
                    break;
                case 6:
                    if (a.Day >= 1 && a.Day <= 21) Zoo = "Song Tử";
                    else Zoo = "Cự Giải";
                    break;
                case 7:
                    if (a.Day >= 1 && a.Day <= 22) Zoo = "Cự Giải";
                    else Zoo = "Sư tử";
                    break;
                case 8:
                    if (a.Day >= 1 && a.Day <= 22) Zoo = "Sư tử";
                    else Zoo = "Xữ Nữ";
                    break;
                case 9:
                    if (a.Day >= 1 && a.Day <= 23) Zoo = "Xữ Nữ";
                    else Zoo = "Thiên Bình";
                    break;
                case 10:
                    if (a.Day >= 1 && a.Day <= 23) Zoo = "Thiên Bình";
                    else Zoo = "Thần Nông";
                    break;
                case 11:
                    if (a.Day >= 1 && a.Day <= 22) Zoo = "Thần Nông";
                    else Zoo = "Nhân Mã";
                    break;
                case 12:
                    if (a.Day >= 1 && a.Day <= 21) Zoo = "Nhân Mã";
                    else Zoo = "Ma kết";
                    break;
            }
            return Zoo;
        }
        public string Day_of_week(string arr)
        {
            string a = arr;
            if (Convert.ToDateTime(arr).DayOfWeek == DayOfWeek.Monday)  a= "Thứ 2";
            if (Convert.ToDateTime(arr).DayOfWeek == DayOfWeek.Tuesday) a = "Thứ 3";
            if (Convert.ToDateTime(arr).DayOfWeek == DayOfWeek.Wednesday)  a = "Thứ 4";
            if (Convert.ToDateTime(arr).DayOfWeek == DayOfWeek.Thursday) a = "Thứ 5";
            if (Convert.ToDateTime(arr).DayOfWeek == DayOfWeek.Friday) a = "Thứ 6";
            if (Convert.ToDateTime(arr).DayOfWeek == DayOfWeek.Saturday) a = "Thứ 7";
            if (Convert.ToDateTime(arr).DayOfWeek == DayOfWeek.Sunday) a = "Chủ Nhật";
            return a;
        }
        private void Print_Click(object sender, EventArgs e)
        {
            Date_Zoo.Text = Day_of_week(Date_time.Text) + Environment.NewLine
                           + Zoodiac(Date_time.Text);
        }

        private void Date_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void Del_Click(object sender, EventArgs e)
        {
            Date_time.Clear();
            Date_Zoo.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
