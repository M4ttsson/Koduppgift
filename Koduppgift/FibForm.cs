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
    public partial class FibForm : Form
    {
        string result;
        bool first = true;

        public FibForm()
        {
            InitializeComponent();
        }

        

        private void fibonacci(int length, long n2 = 0, long n1 = 1)
        {
            if (length != 0)
            {
                //För att få med 0 1 1 som är de tre första siffrorna i fibonacci talföljden.
                if (first && length >= 2)
                {
                    result += " " + n2 + " " + n1;
                    length -= 2;
                    first = false;
                    fibonacci(length, n2, n1);
                }
                else if (first && length == 1)
                {
                    result += " " + n2;
                    length--;
                }
                else
                {
                    long n = n2 + n1;
                    result += " " + n;

                    fibonacci(--length, n1, n);
                }
                
            }
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            result = "";
            first = true;
            try
            {
                int number = Convert.ToInt32(tbTal.Text);
                fibonacci(number);
                MessageBox.Show(result);
            }
            catch (System.FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
