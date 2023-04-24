using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog122b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Hours \t\t Pay");
            int lcv = 1;
            int rate = 4;
            int tot = 0;
            while (lcv <= 40){
                tot = lcv * rate;
                listBox1.Items.Add(lcv + "\t\t" + tot);
                lcv++;

            }
        }
    }
}
