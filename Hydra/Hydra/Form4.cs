using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hydra
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Form2 f2 = new Form2();

            f5.Show();
            Thread.Sleep(100);
            f2.Show();
            Thread.Sleep(1000);
            this.Hide();
        }
    }
}
