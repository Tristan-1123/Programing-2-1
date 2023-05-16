using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG435TicketSales
{
    public partial class Student : Form
    {
        private Form myParent;
        public Student(Form prt)
        {
            InitializeComponent();
            this.myParent = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        decimal decTAXRATE = 0.06m; // sales tax rate
        private decimal CalcTax(decimal cost)
        {
            //returns sales tax on ticket sales
            return cost * decTAXRATE;
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
