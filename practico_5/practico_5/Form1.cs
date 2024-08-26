using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string sexo;
            float saldo = float.Parse(txtSaldo.Text);
            string ruta = txtRuta.Text; // Ruta de la imagen seleccionada
            string fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            // Determinamos el sexo basado en el RadioButton seleccionado
            if (rdbHombre.Checked)
            {
                sexo = "Hombre";
            }
            else
            {
                sexo = "Mujer";
            }

            // Cargar la imagen desde la ruta seleccionada
            Image imagenSeleccionada = null;
            if (!string.IsNullOrEmpty(ruta) && System.IO.File.Exists(ruta))
            {
                imagenSeleccionada = Image.FromFile(ruta); // Carga la imagen desde la ruta
            }

            // Agregar la fila al DataGridView, incluyendo la imagen
            dataGridView1.Rows.Add(apellido, nombre, fecha, sexo, "", saldo, imagenSeleccionada, ruta);

        }

        private void lblFoto_Click(object sender, EventArgs e)
        {
            // Crear un OpenFileDialog para examinar la computadora
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtrar para mostrar solo archivos de imagen
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Mostrar el diálogo y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta completa del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Asignar la ruta al TextBox (suponiendo que se llama txtFilePath)
                txtRuta.Text = filePath;
                pictureBox1.Image=Image.FromFile(filePath);
            }
        }
    }
}
