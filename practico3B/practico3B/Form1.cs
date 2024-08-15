using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDni.MaxLength = 11;
        }


        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solamente numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbtnVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVaron.Checked)
            {
                // Ruta relativa a la imagen desde la ubicación del ejecutable
                string relativePath = @"iconos\varon.png";
                // Combina la ruta de inicio de la aplicación con la ruta relativa
                string fullPath = Path.Combine(Application.StartupPath, relativePath);

                // Verifica si el archivo existe antes de asignarlo al PictureBox
                if (File.Exists(fullPath))
                {
                    pictureBox1.Image = Image.FromFile(fullPath);
                }
                else
                {
                    MessageBox.Show("La imagen no se encuentra.");
                }
            }
        }



        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemenino.Checked)
            {
                // Ruta relativa a la imagen desde la ubicación del ejecutable
                string relativePath = @"iconos\mujer.png";
                // Combina la ruta de inicio de la aplicación con la ruta relativa
                string fullPath = Path.Combine(Application.StartupPath, relativePath);

                // Verifica si el archivo existe antes de asignarlo al PictureBox
                if (File.Exists(fullPath))
                {
                    pictureBox1.Image = Image.FromFile(fullPath);
                }
                else
                {
                    MessageBox.Show("La imagen no se encuentra.");
                }
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (CamposObligatoriosIncompletos())
            {
                MessageBox.Show("Debe llenar todos los campos, seleccionar sexo y al menos una tarjeta",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                DialogResult ask = MessageBox.Show("¿Desea agregar un teléfono?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ask == DialogResult.No)
                {
                    MostrarConfirmaciónAgregarCliente();
                }
            }
            else
            {
                MostrarConfirmaciónAgregarCliente();
            }
        }

        private bool CamposObligatoriosIncompletos()
        {
            return string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   (!rbtnFemenino.Checked && !rbtnVaron.Checked) || (!chkMastercard.Checked && !chkNaranja.Checked && !chkVisa.Checked);
        }

        private void MostrarConfirmaciónAgregarCliente()
        {
            DialogResult result = MessageBox.Show($"¿Desea agregar a {txtApellido.Text} {txtNombre.Text}?",
                                                  "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                lblModificar.Text = $"{txtApellido.Text} {txtNombre.Text}";
                MessageBox.Show($"Cliente {txtApellido.Text} {txtNombre.Text} agregado correctamente",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblModificar.Text != "Modificar")
            {
                DialogResult ask = MessageBox.Show($"¿Desea eliminar a {lblModificar.Text}?",
                                                  "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show($"Cliente {txtApellido.Text} {txtNombre.Text} eliminado correctamente",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtDni.Clear();
                    txtTelefono.Clear();
                    chkMastercard.Checked = false;
                    chkNaranja.Checked = false;
                    chkVisa.Checked = false;
                    rbtnFemenino.Checked = false;
                    rbtnVaron.Checked = false;
                    lblModificar.Text = "Modificar";
                }
            }
            else
            {
                MessageBox.Show("No hay datos que eliminar","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solamente numeros para el Telefono", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
