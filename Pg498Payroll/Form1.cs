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

namespace Pg498Payroll
{
    public partial class Form1 : Form
    {
        const decimal hourly_rate = 6.0m;
        const int int_max_employees = 5;
        //"Const" prevents us from ever changing the value
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intHours = new int[int_max_employees];
            // make a new int array of capacity int_max_employees

            int intcount = 0; // loop counter
            decimal empay = 0;
            int emphours = 0;

            // gets hours worked by employees 
            for (intcount = 0; intcount < int_max_employees; intcount++) {
                while(int.TryParse( 
                    Interaction.InputBox("Enter the number of hours worked by the employee #" + (intcount+1).ToString(), "need hours worked"),
                    out emphours) == false) {
                    MessageBox.Show("Enter an integer for hours worked");
                }
                intHours[intcount] = emphours;
            }
            listBox1.Items.Clear();
            for (intcount = 0; intcount < int_max_employees; intcount++) {
                empay = intHours[intcount] * hourly_rate;
                listBox1.Items.Add("employee " + (intcount+1).ToString()+ " earned "+ empay.ToString("$.00"));
            }
                
            
    }
    }
}
