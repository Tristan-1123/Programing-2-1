using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progs535
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU WON!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
           Random rnd = new Random();
           button1.Location = new Point(rnd.Next(345), rnd.Next(375));
           List<string> words = new List<string> { "Hurry Up!", "Move Faster", "Not Quite!", "Almost!", "Close!", "So Close!", "Give Up!", "Nope!", "C'mon" };
           int x = rnd.Next(9);
           string cap = words[x];
           button1.Text = cap.ToString();
        }
    }
}
