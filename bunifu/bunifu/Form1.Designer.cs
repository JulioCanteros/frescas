namespace bunifu
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
            this.txtDni = new Guna.UI.WinForms.GunaTextBox();
            this.txtApellido = new Guna.UI.WinForms.GunaTextBox();
            this.lblDni = new Guna.UI.WinForms.GunaLabel();
            this.lblApellido = new Guna.UI.WinForms.GunaLabel();
            this.lblNombre = new Guna.UI.WinForms.GunaLabel();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.btnEliminar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaGradientButton();
            this.lblResultado = new Guna.UI.WinForms.GunaLabel();
            this.btnSalir = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.BaseColor = System.Drawing.Color.White;
            this.txtDni.BorderColor = System.Drawing.Color.MediumBlue;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDni.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDni.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.ForeColor = System.Drawing.Color.Blue;
            this.txtDni.Location = new System.Drawing.Point(198, 88);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(160, 30);
            this.txtDni.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.BaseColor = System.Drawing.Color.White;
            this.txtApellido.BorderColor = System.Drawing.Color.MediumBlue;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApellido.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtApellido.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.ForeColor = System.Drawing.Color.Blue;
            this.txtApellido.Location = new System.Drawing.Point(198, 149);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(160, 30);
            this.txtApellido.TabIndex = 4;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDni.Location = new System.Drawing.Point(46, 88);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 17);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApellido.Location = new System.Drawing.Point(46, 149);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(53, 17);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.Location = new System.Drawing.Point(46, 208);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 17);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.MediumBlue;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.ForeColor = System.Drawing.Color.Blue;
            this.txtNombre.Location = new System.Drawing.Point(198, 208);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(160, 30);
            this.txtNombre.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BaseColor1 = System.Drawing.Color.DarkBlue;
            this.btnEliminar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(265, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnEliminar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Size = new System.Drawing.Size(143, 42);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BaseColor1 = System.Drawing.Color.DarkBlue;
            this.btnGuardar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(32, 331);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnGuardar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(139, 42);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(555, 135);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 23);
            this.lblResultado.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.AnimationHoverSpeed = 0.07F;
            this.btnSalir.AnimationSpeed = 0.03F;
            this.btnSalir.BaseColor1 = System.Drawing.Color.DarkBlue;
            this.btnSalir.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalir.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalir.Location = new System.Drawing.Point(618, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSalir.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSalir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalir.OnHoverImage = null;
            this.btnSalir.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalir.Size = new System.Drawing.Size(116, 85);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtDni;
        private Guna.UI.WinForms.GunaTextBox txtApellido;
        private Guna.UI.WinForms.GunaLabel lblDni;
        private Guna.UI.WinForms.GunaLabel lblApellido;
        private Guna.UI.WinForms.GunaLabel lblNombre;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaGradientButton btnEliminar;
        private Guna.UI.WinForms.GunaGradientButton btnGuardar;
        private Guna.UI.WinForms.GunaLabel lblResultado;
        private Guna.UI.WinForms.GunaGradientButton btnSalir;
    }
}

