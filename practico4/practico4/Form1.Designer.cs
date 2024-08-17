namespace practico4
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
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(36, 72);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(36, 113);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(239, 72);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(115, 27);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(411, 72);
            this.lista.MultiColumn = true;
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(194, 355);
            this.lista.TabIndex = 3;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(97, 72);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 4;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(97, 113);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 5;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(97, 189);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(115, 27);
            this.btnPares.TabIndex = 6;
            this.btnPares.Text = "Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(97, 244);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(115, 27);
            this.btnImpares.TabIndex = 7;
            this.btnImpares.Text = "Impares";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // btnPrimos
            // 
            this.btnPrimos.Location = new System.Drawing.Point(97, 302);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(115, 27);
            this.btnPrimos.TabIndex = 8;
            this.btnPrimos.Text = "Primos";
            this.btnPrimos.UseVisualStyleBackColor = true;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(221, 19);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(209, 24);
            this.lblLista.TabIndex = 9;
            this.lblLista.Text = "LISTA DE NUMEROS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnPrimos);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.Button btnPrimos;
        private System.Windows.Forms.Label lblLista;
    }
}

