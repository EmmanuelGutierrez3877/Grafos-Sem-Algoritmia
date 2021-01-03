namespace Etapa6
{
    partial class ventanaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipalForm));
            this.botonVuelos = new System.Windows.Forms.Button();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.presentacion = new System.Windows.Forms.Label();
            this.buttonPasajeros = new System.Windows.Forms.Button();
            this.buttonGrafo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVuelos
            // 
            this.botonVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVuelos.Location = new System.Drawing.Point(89, 374);
            this.botonVuelos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonVuelos.Name = "botonVuelos";
            this.botonVuelos.Size = new System.Drawing.Size(179, 70);
            this.botonVuelos.TabIndex = 1;
            this.botonVuelos.Text = "Vuelos";
            this.botonVuelos.UseVisualStyleBackColor = true;
            this.botonVuelos.Click += new System.EventHandler(this.botonVuelos_Click);
            // 
            // logo1
            // 
            this.logo1.Image = ((System.Drawing.Image)(resources.GetObject("logo1.Image")));
            this.logo1.Location = new System.Drawing.Point(169, 15);
            this.logo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(308, 292);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo1.TabIndex = 2;
            this.logo1.TabStop = false;
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.Location = new System.Drawing.Point(49, 293);
            this.presentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(524, 50);
            this.presentacion.TabIndex = 3;
            this.presentacion.Text = "Aerolineas Santillan";
            this.presentacion.Click += new System.EventHandler(this.presentacion_Click);
            // 
            // buttonPasajeros
            // 
            this.buttonPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPasajeros.Location = new System.Drawing.Point(364, 374);
            this.buttonPasajeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPasajeros.Name = "buttonPasajeros";
            this.buttonPasajeros.Size = new System.Drawing.Size(179, 70);
            this.buttonPasajeros.TabIndex = 4;
            this.buttonPasajeros.Text = "Pasajeros";
            this.buttonPasajeros.UseVisualStyleBackColor = true;
            this.buttonPasajeros.Click += new System.EventHandler(this.buttonPasajeros_Click);
            // 
            // buttonGrafo
            // 
            this.buttonGrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrafo.Location = new System.Drawing.Point(620, 374);
            this.buttonGrafo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGrafo.Name = "buttonGrafo";
            this.buttonGrafo.Size = new System.Drawing.Size(179, 70);
            this.buttonGrafo.TabIndex = 5;
            this.buttonGrafo.Text = "Grafo";
            this.buttonGrafo.UseVisualStyleBackColor = true;
            this.buttonGrafo.Click += new System.EventHandler(this.buttonGrafo_Click);
            // 
            // ventanaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 482);
            this.Controls.Add(this.buttonGrafo);
            this.Controls.Add(this.buttonPasajeros);
            this.Controls.Add(this.presentacion);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.botonVuelos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ventanaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.ventanaPrincipalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonVuelos;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.Label presentacion;
        private System.Windows.Forms.Button buttonPasajeros;
        private System.Windows.Forms.Button buttonGrafo;
    }
}

