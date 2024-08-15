using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int desde = int.Parse(txtDesde.Text);
            int hasta=int.Parse(txtHasta.Text);

            lista.Items.Clear();

            for(int i = desde; i <= hasta; i++)
            {
                lista.Items.Add(i);
            }
            
            

        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int desde = int.Parse(txtDesde.Text);
            int hasta = int.Parse(txtHasta.Text);

            lista.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
               // lista.Items.Add(i);
               if(i>0 && i % 2 == 0)
                {
                    lista.Items.Add(i);
                }
            }
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            int desde = int.Parse(txtDesde.Text);
            int hasta = int.Parse(txtHasta.Text);

            lista.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
                // lista.Items.Add(i);
                if (i > 0 && i % 2 != 0)
                {
                    lista.Items.Add(i);
                }
            }
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            int desde = int.Parse(txtDesde.Text);
            int hasta = int.Parse(txtHasta.Text);
            int contador = 0;

            lista.Items.Clear();
            
            for (int i = desde; i <= hasta; i++)
            {
                for(int j = i; j >= desde; j--)
                {
                    if (i!=0 && j!=0 && i % j == 0) { contador++; };
                }
                if(contador==2)
                {
                    lista.Items.Add(i);
                }
                contador = 0;
            }
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
        }
    }
}
