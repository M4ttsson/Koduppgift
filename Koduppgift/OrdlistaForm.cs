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
    public partial class OrdlistaForm : Form
    {
        private char[] vokalerna = { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
        public OrdlistaForm()
        {
            InitializeComponent();
        }

        private void bBokOrdning_Click(object sender, EventArgs e)
        {
            //Sparar innehållet i textboxen till en array av strings och sorterar efter bokstav och skriver sen ut allt igen i ny ordning.
            string temp = tbLista.Text;
            tbLista.Text = "";
            string[] ordlista = temp.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var ord = from o
                    in ordlista
                      orderby o
                      select o;

            foreach (var o in ord)
            {
                tbLista.Text += o + System.Environment.NewLine;
            }
        }

        private void bLangd_Click(object sender, EventArgs e)
        {
            //sorterar efter längd
            string temp = tbLista.Text;
            tbLista.Text = "";
            string[] ordlista = temp.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var langd = from o
                        in ordlista
                        orderby o.Length descending
                        select o;

            foreach (var o in langd)
            {
                tbLista.Text += o + System.Environment.NewLine;
            }
        }

        private void bVokal_Click(object sender, EventArgs e)
        {
            string temp = tbLista.Text;
            tbLista.Text = "";
            string[] ordlista = temp.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //sorterar efter hur många vokaler ordet innehåller
            var vokal = ordlista.OrderByDescending(str => AntalVokaler(str));
            foreach (var o in vokal)
            {
                tbLista.Text += o + System.Environment.NewLine;
            }
        }

        /// <summary>
        /// Räknar antalet vokaler i ett ord
        /// </summary>
        /// <param name="ord">Ord att kolla</param>
        /// <returns>Antalet vokaler</returns>
        private int AntalVokaler(string ord)
        {
            int nr = 0;

            var v = from o
                    in ord
                    where vokalerna.Contains(Convert.ToChar(o.ToString().ToUpper()))
                    select o;
            nr = v.Count();
            return nr;
        }

    }
}
