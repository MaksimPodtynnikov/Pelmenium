using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelmenium
{
    public partial class Form1 : Form
    {
        const int T = 7;
        double Ppa =0, Q=0, At = 0, Ptm = 0, Pk = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateData();
            Result1.Text = Ptln().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateData(); 
            Result3.Text = n().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateData(); 
            Result2.Text = Ptlt().ToString();
        }

        private void PowerPelmen_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void PelmenTillDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void massProcent_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void CutterPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private double Ptln()
        {
            return Q / (2 * T) / Ppa;
        }
        private double Ptlt()
        {
            return At * Ptln() / 100 / Ptm;
        }
        private double n()
        {
            return (100 - At)*Ptln()/100;
        }
        private void updateData()
        {
            if (PowerPelmen.Text != "")
                Ppa = Double.Parse(PowerPelmen.Text);
            if (PelmenTillDay.Text != "")
                Q = Double.Parse(PelmenTillDay.Text);
            if (CutterPower.Text!="")
                Pk = Double.Parse(CutterPower.Text);
            if (massProcent.Text != "")
                At = Double.Parse(massProcent.Text);
            if (Power.Text != "")
                Ptm = Double.Parse(Power.Text);
        }
    }
}
