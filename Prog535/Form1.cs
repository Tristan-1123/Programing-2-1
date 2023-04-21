using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog535
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numx = rnd.Next(1, 410);
            int numy = rnd.Next(1, 410);

            private string[] btncap = {"Click Here!", "Try Again!", "C'mon",""  };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya got me...");
        }
    }
}
