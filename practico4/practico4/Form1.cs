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
            if (!string.IsNullOrEmpty(txtDesde.Text) && !string.IsNullOrEmpty(txtHasta.Text))
            {
                int desde = int.Parse(txtDesde.Text);
                int hasta = int.Parse(txtHasta.Text);

                lista.Items.Clear();

                for (int i = desde; i <= hasta; i++)
                {
                    lista.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("Debe introducir valores en ambos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDesde.Text) && !string.IsNullOrEmpty(txtHasta.Text))
            {
                int desde = int.Parse(txtDesde.Text);
                int hasta = int.Parse(txtHasta.Text);

                lista.Items.Clear();

                for (int i = desde; i <= hasta; i++)
                {
                    // lista.Items.Add(i);
                    /* if(i>0 && i % 2 == 0)
                      {
                          lista.Items.Add(i);
                      }*/
                    if (esPar(i))
                    {

                        lista.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe introducir valores en ambos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtDesde.Text) && !string.IsNullOrEmpty(txtHasta.Text))
            {
                int desde = int.Parse(txtDesde.Text);
                int hasta = int.Parse(txtHasta.Text);

                lista.Items.Clear();

                for (int i = desde; i <= hasta; i++)
                {

                    /* if (i > 0 && i % 2 != 0)
                     {
                         lista.Items.Add(i);
                     }*/
                    if (!esPar(i) && i != 0)
                    {

                        lista.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe introducir valores en ambos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtDesde.Text) && !string.IsNullOrEmpty(txtHasta.Text))
            {
                int desde = int.Parse(txtDesde.Text);
                int hasta = int.Parse(txtHasta.Text);
                int contador = 0;

                lista.Items.Clear();

                for (int i = desde; i <= hasta; i++)
                {
                    for (int j = i; j >= 1; j--)
                    {
                        if (i != 0 && j != 0 && i % j == 0) { contador++; };
                    }
                    if (contador == 2)
                    {
                        lista.Items.Add(i);
                    }
                    contador = 0;
                }
            }
            else
            {
                MessageBox.Show("Debe introducir valores en ambos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool esPar(int N)
        {
            if (N > 0 && N % 2 == 0)
            {
                return true;
            }
            return false;
        }

       /* private bool esPrimo(int i, int j)
        {
            int contador = 0;
            for (int j = i; j >= 1; j--)
            {
                if (i != 0 && j != 0 && i % j == 0) { contador++; };
            }
            if (contador == 2)
            {
                return true;
            }
            contador = 0;
        }*/
        
    }
}


