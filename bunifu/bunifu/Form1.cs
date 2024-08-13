using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblResultado.Text=txtApellido.Text+" "+txtNombre.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            lblResultado.Text = "";
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo");
        }
    }
}
