namespace practico3B
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblNyA = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.chkMastercard = new System.Windows.Forms.CheckBox();
            this.chkVisa = new System.Windows.Forms.CheckBox();
            this.chkNaranja = new System.Windows.Forms.CheckBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnVaron = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Controls.Add(this.lblNyA);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.chkMastercard);
            this.panel1.Controls.Add(this.chkVisa);
            this.panel1.Controls.Add(this.chkNaranja);
            this.panel1.Controls.Add(this.lblTarjetas);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 392);
            this.panel1.TabIndex = 1;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.Red;
            this.lblModificar.Location = new System.Drawing.Point(170, 35);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(87, 20);
            this.lblModificar.TabIndex = 14;
            this.lblModificar.Text = "Modificar";
            // 
            // lblNyA
            // 
            this.lblNyA.AutoSize = true;
            this.lblNyA.Location = new System.Drawing.Point(21, 35);
            this.lblNyA.Name = "lblNyA";
            this.lblNyA.Size = new System.Drawing.Size(119, 16);
            this.lblNyA.TabIndex = 13;
            this.lblNyA.Text = "Nombre y Apellido";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Location = new System.Drawing.Point(119, 201);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(143, 15);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(119, 161);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 15);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Location = new System.Drawing.Point(119, 116);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(143, 15);
            this.txtApellido.TabIndex = 9;
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Location = new System.Drawing.Point(119, 74);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(143, 15);
            this.txtDni.TabIndex = 8;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // chkMastercard
            // 
            this.chkMastercard.AutoSize = true;
            this.chkMastercard.Location = new System.Drawing.Point(174, 330);
            this.chkMastercard.Name = "chkMastercard";
            this.chkMastercard.Size = new System.Drawing.Size(97, 20);
            this.chkMastercard.TabIndex = 7;
            this.chkMastercard.Text = "Mastercard";
            this.chkMastercard.UseVisualStyleBackColor = true;
            // 
            // chkVisa
            // 
            this.chkVisa.AutoSize = true;
            this.chkVisa.Location = new System.Drawing.Point(174, 291);
            this.chkVisa.Name = "chkVisa";
            this.chkVisa.Size = new System.Drawing.Size(56, 20);
            this.chkVisa.TabIndex = 6;
            this.chkVisa.Text = "Visa";
            this.chkVisa.UseVisualStyleBackColor = true;
            // 
            // chkNaranja
            // 
            this.chkNaranja.AutoSize = true;
            this.chkNaranja.Location = new System.Drawing.Point(175, 255);
            this.chkNaranja.Name = "chkNaranja";
            this.chkNaranja.Size = new System.Drawing.Size(77, 20);
            this.chkNaranja.TabIndex = 5;
            this.chkNaranja.Text = "Naranja";
            this.chkNaranja.UseVisualStyleBackColor = true;
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(21, 249);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(123, 16);
            this.lblTarjetas.TabIndex = 4;
            this.lblTarjetas.Text = "Tarjetas de credito:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(21, 201);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 161);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "*Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 116);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "*Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 74);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 16);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "*DNI";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(236, 494);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 70);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(457, 494);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 70);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnVaron
            // 
            this.rbtnVaron.AutoSize = true;
            this.rbtnVaron.BackColor = System.Drawing.Color.Transparent;
            this.rbtnVaron.Checked = true;
            this.rbtnVaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVaron.Location = new System.Drawing.Point(409, 264);
            this.rbtnVaron.Name = "rbtnVaron";
            this.rbtnVaron.Size = new System.Drawing.Size(98, 20);
            this.rbtnVaron.TabIndex = 6;
            this.rbtnVaron.TabStop = true;
            this.rbtnVaron.Text = "Masculino";
            this.rbtnVaron.UseVisualStyleBackColor = false;
            this.rbtnVaron.CheckedChanged += new System.EventHandler(this.rbtnVaron_CheckedChanged);
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(515, 264);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(96, 20);
            this.rbtnFemenino.TabIndex = 7;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = false;
            this.rbtnFemenino.CheckedChanged += new System.EventHandler(this.rbtnFemenino_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(73, 494);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 70);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 586);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.rbtnVaron);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Pequeño formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkMastercard;
        private System.Windows.Forms.CheckBox chkVisa;
        private System.Windows.Forms.CheckBox chkNaranja;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblNyA;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnVaron;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.Button btnGuardar;
    }
}

