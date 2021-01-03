namespace Etapa6
{
    partial class VentanaCompraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCompraForm));
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxVuelo = new System.Windows.Forms.TextBox();
            this.labelVuelo = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.buttonAsientos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoleto = new System.Windows.Forms.PictureBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxAsiento = new System.Windows.Forms.TextBox();
            this.labelAsiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoleto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(48, 89);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(130, 32);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(187, 85);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(320, 38);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(187, 142);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(320, 38);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(48, 144);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(136, 32);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido:";
            // 
            // textBoxVuelo
            // 
            this.textBoxVuelo.Enabled = false;
            this.textBoxVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVuelo.Location = new System.Drawing.Point(187, 255);
            this.textBoxVuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxVuelo.Name = "textBoxVuelo";
            this.textBoxVuelo.Size = new System.Drawing.Size(320, 38);
            this.textBoxVuelo.TabIndex = 7;
            // 
            // labelVuelo
            // 
            this.labelVuelo.AutoSize = true;
            this.labelVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVuelo.Location = new System.Drawing.Point(48, 258);
            this.labelVuelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVuelo.Name = "labelVuelo";
            this.labelVuelo.Size = new System.Drawing.Size(103, 32);
            this.labelVuelo.TabIndex = 6;
            this.labelVuelo.Text = "Vuelo:";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEdad.Location = new System.Drawing.Point(187, 199);
            this.textBoxEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(320, 38);
            this.textBoxEdad.TabIndex = 5;
            this.textBoxEdad.TextChanged += new System.EventHandler(this.textBoxEdad_TextChanged);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(48, 202);
            this.labelEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(95, 32);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(187, 302);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(320, 38);
            this.textBoxPrecio.TabIndex = 9;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(48, 304);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(111, 32);
            this.labelPrecio.TabIndex = 8;
            this.labelPrecio.Text = "Precio:";
            // 
            // buttonAsientos
            // 
            this.buttonAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsientos.Location = new System.Drawing.Point(407, 417);
            this.buttonAsientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAsientos.Name = "buttonAsientos";
            this.buttonAsientos.Size = new System.Drawing.Size(133, 66);
            this.buttonAsientos.TabIndex = 10;
            this.buttonAsientos.Text = "Asientos";
            this.buttonAsientos.UseVisualStyleBackColor = true;
            this.buttonAsientos.Click += new System.EventHandler(this.buttonAsientos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datos de compra:";
            // 
            // pictureBoleto
            // 
            this.pictureBoleto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoleto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoleto.Image")));
            this.pictureBoleto.Location = new System.Drawing.Point(-3, 320);
            this.pictureBoleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoleto.Name = "pictureBoleto";
            this.pictureBoleto.Size = new System.Drawing.Size(475, 320);
            this.pictureBoleto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoleto.TabIndex = 12;
            this.pictureBoleto.TabStop = false;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Enabled = false;
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.Location = new System.Drawing.Point(407, 510);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(133, 66);
            this.buttonRegistrar.TabIndex = 13;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxAsiento
            // 
            this.textBoxAsiento.Enabled = false;
            this.textBoxAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAsiento.Location = new System.Drawing.Point(187, 356);
            this.textBoxAsiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAsiento.Name = "textBoxAsiento";
            this.textBoxAsiento.Size = new System.Drawing.Size(320, 38);
            this.textBoxAsiento.TabIndex = 15;
            this.textBoxAsiento.TextChanged += new System.EventHandler(this.textBoxAsiento_TextChanged);
            // 
            // labelAsiento
            // 
            this.labelAsiento.AutoSize = true;
            this.labelAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsiento.Location = new System.Drawing.Point(48, 359);
            this.labelAsiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAsiento.Name = "labelAsiento";
            this.labelAsiento.Size = new System.Drawing.Size(127, 32);
            this.labelAsiento.TabIndex = 14;
            this.labelAsiento.Text = "Asiento:";
            this.labelAsiento.Click += new System.EventHandler(this.label2_Click);
            // 
            // VentanaCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 617);
            this.Controls.Add(this.textBoxAsiento);
            this.Controls.Add(this.labelAsiento);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAsientos);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxVuelo);
            this.Controls.Add(this.labelVuelo);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBoleto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaCompraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.VentanaCompraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoleto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxVuelo;
        private System.Windows.Forms.Label labelVuelo;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button buttonAsientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoleto;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxAsiento;
        private System.Windows.Forms.Label labelAsiento;
    }
}