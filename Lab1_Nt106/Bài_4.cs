using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Nt106
{
    public partial class Bài_4 : Form
    {
       
        public Bài_4()
        {
            InitializeComponent();
        }
        
        private void Bike_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fuel_Type.Items.Clear();
            if (Bike_Type.Text == "Wave Alpha")
            {
                Fuel_Type.Items.Add("RON 95-III");
                Fuel_Type.Items.Add("Ron 92-II");
            }
            else if (Bike_Type.Text == "Sirius")
            {
                Fuel_Type.Items.Add("RON 95-III");
                Fuel_Type.Items.Add("Ron 92-II");
            }
            else if (Bike_Type.Text == "Vision")
            {
                Fuel_Type.Items.Add("RON 95-III");
                Fuel_Type.Items.Add("Ron 92-II");
            }
            else if (Bike_Type.Text == "Lead")
                Fuel_Type.Items.Add("RON 95-III");
            else if (Bike_Type.Text == "Winner")
                Fuel_Type.Items.Add("RON 95-III");
            else if (Bike_Type.Text == "Air Blade")
                Fuel_Type.Items.Add("RON 95-III");
            else if (Bike_Type.Text == "Xe tải 9 tấn")
                Fuel_Type.Items.Add("DO");
        }

        private void Bài_4_Load(object sender, EventArgs e)
        {
            Bike_Type.Items.Add("Wave Alpha");
            Bike_Type.Items.Add("Sirius");
            Bike_Type.Items.Add("Vision");
            Bike_Type.Items.Add("Lead");
            Bike_Type.Items.Add("Winner");
            Bike_Type.Items.Add("Air Blade");
            Bike_Type.Items.Add("Xe tải 9 tấn");
        }
        private void Fuel_Cacu()
        {
            double Fuel_Tp = 0;
            if (Fuel_Type.Text == "RON 95-III") Fuel_Tp = 26830;
            else if (Fuel_Type.Text == "Ron 92-II") Fuel_Tp = 26070;
            else if (Fuel_Type.Text == "DO") Fuel_Tp = 21310;
            double Fuel_Km = 0;
            double Fuel_Contain = 0; ;
            if(Bike_Type.Text =="Wave Alpha")
            {
                Fuel_Km = 1.6;
                Fuel_Contain= 3.7;
            }
            if (Bike_Type.Text == "Sirius")
            {
                Fuel_Km = 1.99;
                Fuel_Contain = 3.8;
            }
            if (Bike_Type.Text == "Vision")
            {
                Fuel_Km = 1.87;
                Fuel_Contain = 5.2;
            }
            if (Bike_Type.Text == "Lead")
            {
                Fuel_Km = 2.02;
                Fuel_Contain = 6;
            }
            if (Bike_Type.Text == "Winner")
            {
                Fuel_Km = 1.7;
                Fuel_Contain = 4.5;
            }
            if (Bike_Type.Text == "Air Blade")
            {
                Fuel_Km = 2.17;
                Fuel_Contain = 4.4;
            }
            if (Bike_Type.Text == "Xe tải 9 tấn")
            {
                Fuel_Km = 13;
                Fuel_Contain = 70;
            }
            double Km_count = (Fuel_Contain / Fuel_Km) * 100;
            double Money = Fuel_Contain * Fuel_Tp;
            Fuel_Cal.Text = Convert.ToString(Km_count) + Environment.NewLine +Convert.ToString(Money);

        }
        private void Fuel_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Fuel_Cal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fuel_Cacu();
  
        }
    }
}
