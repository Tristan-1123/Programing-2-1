using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lang334
{
    public partial class Form1 : Form
    {
        const int min = 6;
        const int max = 48;
        const float months = 12.0f;

        const double new_rate = 0.089;
        const double used_rate = 0.095;

        double annual_rate = new_rate;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intCount = 0;
            int intMonths = 0;
            double dblLoan = 0.0;
            double dblPayment = 0.0;
            double dblInterest = 0.0;
            double dblPrinciple = 0.0;

            try{
            intMonths = int.Parse(textBox3.Text);
            dblLoan = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            } catch (Exception ex) {
                MessageBox.Show("Please Enter Numeic Values.");
                return;
            }

            dblPayment = Financial.Pmt(annual_rate / months, intMonths, -dblLoan);
            listBox1.Items.Clear();

            for (intCount = 1; intCount <= intMonths; intCount++)
            {
                string strOut = string.Empty;
                dblInterest = Financial.IPmt(annual_rate / months, intCount, intMonths, -dblLoan);
                dblPrinciple = Financial.IPmt(annual_rate / months, intCount, intMonths, -dblLoan);
                strOut += " Month: " + intCount;
                strOut += " Payment: " + dblPayment.ToString("$.00");
                strOut += " Interest: " + dblInterest.ToString("$.00");
                strOut += " Principle: " + dblPrinciple.ToString("$.00");

                listBox1.Items.Add(strOut);



            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                annual_rate = new_rate;
                label4.Text = new_rate.ToString(".00%");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                annual_rate = used_rate;
                label4.Text = used_rate.ToString(".00%");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(textBox1.Text, out _x))
            {
                MessageBox.Show("Cost must be a number.", "Invalid");
                textBox1.SelectAll();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(textBox2.Text, out _x))
            {
                MessageBox.Show("Down payment must be a number.", "Invalid Down Payment");
                textBox2.SelectAll();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(textBox3.Text, out _x))
            {
                MessageBox.Show("Months must be a number.", "Error");
                textBox3.SelectAll();
                e.Cancel = true;
            }
            else
            {
                int intMonths = int.Parse(textBox3.Text);
                if (intMonths < min || intMonths > max)
                {
                    MessageBox.Show("Months must be in range 6-48.", "Error");
                    textBox3.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
    }
}
