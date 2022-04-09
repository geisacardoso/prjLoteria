using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prlLoteria2J
{
    public partial class FormCartela : Form
    {
        public FormCartela()
        {
            InitializeComponent();
        }

        private void btnGerarCartela_Click(object sender, EventArgs e)
        {
            if (rbMega.Checked)
            {
                Cartela c = new Cartela(60);
                c.Imprimir(pnCartelas, 6, 10);
                c.sortear(60, 6);
            }

            if (rbLotoMania.Checked)
            {
                Cartela c = new Cartela(100);
                c.Imprimir(pnCartelas, 10, 10);
                c.sortear(100,50);
            }

            if (rbLotoFacil.Checked)
            {
                Cartela c = new Cartela(25);
                c.Imprimir(pnCartelas, 5, 5);
                c.sortear(25, 15);
            }

            if (rbQuina.Checked)
            {
                Cartela c = new Cartela(80);
                c.Imprimir(pnCartelas, 8, 10);
                c.sortear(80, 5);
            }
        }
    }
}
