using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koduppgift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FibForm fb = new FibForm();
            fb.Show();
        }

        private void bOrdlista_Click(object sender, EventArgs e)
        {
            OrdlistaForm ordF = new OrdlistaForm();
            ordF.Show();
        }

        private void bLon_Click(object sender, EventArgs e)
        {
            Lonesystem lonF = new Lonesystem();
            lonF.Show();
        }
    }
}
