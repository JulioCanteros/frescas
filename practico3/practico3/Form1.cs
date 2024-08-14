using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Ingrese solo numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Ingrese solo letras", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDni.Text)  || string.IsNullOrEmpty(txtApellido.Text)|| string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {  
                DialogResult ask= MessageBox.Show("Seguro ingresar un nuevo Cliente??", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    LNyA.Text = txtApellido.Text + " " + txtNombre.Text;
                    MessageBox.Show(LNyA.Text + " " + "agregado correctamente", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text.Length > 11)
            {
                txtDni.Text = txtDni.Text.Substring(0, 11);
                txtDni.SelectionStart = txtDni.Text.Length; 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (LNyA.Text != "Modificar") {
                DialogResult ask = MessageBox.Show("Esta seguro que desea eliminar al cliente" + " " + LNyA.Text + "  ?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes) {
                    txtDni.Clear();
                    txtApellido.Clear();
                    txtNombre.Clear();
                    LNyA.Text = "Modificar";

            }
        }
            
        }
    }
}
