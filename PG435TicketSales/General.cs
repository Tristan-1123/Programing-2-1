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
    public partial class General : Form
    {
        private Form myParent; 
        public General(Form prt)
        {
            InitializeComponent();
            myParent = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        decimal decTAXRATE = 0.06m; // sales tax rate
        private decimal CalcTax(decimal cost)
        {
            return cost * decTAXRATE;
        }

        private void General_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }

        private void General_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            decimal decTicketCost = 0.0m;
            decimal decSalesTax = 0.0m;
            decimal decTotal = 0.0m;

             decTicketCost = 

        }
    }
}
