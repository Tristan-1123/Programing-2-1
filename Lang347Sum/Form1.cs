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

namespace Lang347Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lcv = int.Parse(Interaction.InputBox("Prompt here", "Input Numbers"));
            int total = 0;
            for (int start = 0; start <= lcv; ++start){
                total += start;
            }
            MessageBox.Show("The sum of numbers between 1 and " + lcv + " eqauls " + total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
