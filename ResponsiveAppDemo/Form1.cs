using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonResponsiveAppDemo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thread = new Thread(SomeLongRunningOperaton);
            thread.Start();
        }

        private static void SomeLongRunningOperaton()
        {
            Thread.Sleep(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "You Clicked Me!\n";
        }
    }
}
