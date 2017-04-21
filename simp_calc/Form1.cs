using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace simp_calc
{
    public partial class Skaiciuokle : Form
    {
        private double atsa = 0;

        public Skaiciuokle()
        {
            InitializeComponent();
        }


        private void sudeti_Click_1(object sender, EventArgs e)
        {

            bool kintXteisingas = Regex.IsMatch(num1.Text, @"^-?\d+(\.\d*)?$");
            bool kintYteisingas = Regex.IsMatch(num2.Text, @"^-?\d+(\.\d*)?$");

            if (!kintXteisingas)
            {
                MessageBox.Show("1 skaičius neteisingas arba tuščias");
                return;
            }
            if (!kintYteisingas)
            {
                MessageBox.Show("2 skaičius neteisingas arba tuščias");
                return;
            }
            if (kintXteisingas == true || kintYteisingas == true)
            {
                double number1 = Convert.ToDouble(num1.Text);
                double number2 = Convert.ToDouble(num2.Text);
                atsa = PaprastosFunkcijos.sudetis(number1, number2);
            }
        }



        private void atimti_Click(object sender, EventArgs e)
        {

            bool kintXteisingas = Regex.IsMatch(num1.Text, @"^-?\d+(\.\d*)?$");
            bool kintYteisingas = Regex.IsMatch(num2.Text, @"^-?\d+(\.\d*)?$");

            if (!kintXteisingas)
            {
                MessageBox.Show("neteisingas pirmas sk");
                return;
            }
            if (!kintYteisingas)
            {
                MessageBox.Show("2 skaičius neteisingas arba tuščias");
                return;
            }
            if (kintXteisingas == true || kintYteisingas == true)
            {
                double number1 = Convert.ToDouble(num1.Text);
                double number2 = Convert.ToDouble(num2.Text);

                atsa = PaprastosFunkcijos.atimtis(number1, number2);
            }
        }

        private void dauginti_Click(object sender, EventArgs e)
        {

            bool kintXteisingas = Regex.IsMatch(num1.Text, @"^-?\d+(\.\d*)?$");
            bool kintYteisingas = Regex.IsMatch(num2.Text, @"^-?\d+(\.\d*)?$");

            if (!kintXteisingas)
            {
                MessageBox.Show("1 skaičius neteisingas arba tuščias");
                return;
            }
            if (!kintYteisingas)
            {
                MessageBox.Show("2 skaičius neteisingas arba tuščias");
                return;
            }
            if (kintXteisingas == true || kintYteisingas == true)
            {

                double number1 = Convert.ToDouble(num1.Text);
                double number2 = Convert.ToDouble(num2.Text);

                atsa = PaprastosFunkcijos.daugyba(number1, number2);
            }
        }

        private void dalinti_Click(object sender, EventArgs e)
        {

            bool kintXteisingas = Regex.IsMatch(num1.Text, @"^-?\d+(\.\d*)?$");
            bool kintYteisingas = Regex.IsMatch(num2.Text, @"^-?\d+(\.\d*)?$");

            if (!kintXteisingas)
            {
                MessageBox.Show("1 skaičius neteisingas arba tuščias");
                return;
            }
            if (!kintYteisingas)
            {
                MessageBox.Show("2 skaičius neteisingas arba tuščias");
                return;
            }
            if (kintXteisingas == true || kintYteisingas == true)
            {
                double number1 = Convert.ToDouble(num1.Text);
                double number2 = Convert.ToDouble(num2.Text);

                atsa = PaprastosFunkcijos.dalyba(number1, number2);
            }
        }

        private void kel_l_Click(object sender, EventArgs e)
        {
            bool kintXteisingas = Regex.IsMatch(num1.Text, @"^-?\d+(\.\d*)?$");
            bool kintYteisingas = Regex.IsMatch(num2.Text, @"^-?\d+(\.\d*)?$");

            if (!kintXteisingas)
            {
                MessageBox.Show("1 skaičius neteisingas arba tuščias");
                return;
            }
            if (!kintYteisingas)
            {
                MessageBox.Show("2 skaičius neteisingas arba tuščias");
                return;
            }
            if (kintXteisingas == true || kintYteisingas == true)
            {
                double number1 = Convert.ToDouble(num1.Text);
                double number2 = Convert.ToDouble(num2.Text);
                atsa = SudetingosFunkcijos.kelimasLaipsniu(number1, number2);
            }


        }

        private void faktorialas_Click(object sender, EventArgs e)
        {

            bool fak_number = Regex.IsMatch(num_fact.Text, @"^\d+$");
            if (fak_number == false)
            {
                MessageBox.Show("Įveskite teigiamą skaičių");
                return;
            }
            else
            {
                ulong fakt_num = Convert.ToUInt64(num_fact.Text);
                atsa = SudetingosFunkcijos.faktorialas(fakt_num);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ats.Text = atsa.ToString();
        }




    }
}




class PaprastosFunkcijos
{
    public static double sudetis(double a, double b)
    {
        return a + b;
    }

    public static double atimtis(double a, double b)
    {
        return a - b;
    }

    public static double daugyba(double a, double b)
    {
        return a * b;
    }

    public static ulong daugyba(ulong a, ulong b)
    {
        return a * b;
    }

    public static double dalyba(double a, double b)
    {
        return a / b;
    }
}

class SudetingosFunkcijos
{

    public static ulong faktorialas(ulong a)
    {
        ulong i = 1;
        ulong fakt = 1;
        while (i <= a)
        {
            fakt = PaprastosFunkcijos.daugyba(fakt, i);
            i++;
        }
        return fakt;
    }
    public static double kelimasLaipsniu(double c, double d)
    {

        int i = 1;
        double pakeltas_skaic = 1;
        while (i <= d)
        {
            pakeltas_skaic = PaprastosFunkcijos.daugyba(pakeltas_skaic, c);
            i++;
        }
        return pakeltas_skaic;
    }

}

