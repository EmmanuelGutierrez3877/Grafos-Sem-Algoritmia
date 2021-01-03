namespace Etapa6
{
    partial class ventanaPasajerosForm
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
            this.labelPasajeros = new System.Windows.Forms.Label();
            this.lisBoxPasajeros = new System.Windows.Forms.ListBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.radioButtonVuelo = new System.Windows.Forms.RadioButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.radioButtonAsiento = new System.Windows.Forms.RadioButton();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBoxOrdenar = new System.Windows.Forms.GroupBox();
            this.radioButtonOVuelo = new System.Windows.Forms.RadioButton();
            this.radioButtonONombre = new System.Windows.Forms.RadioButton();
            this.radioButtonOAsiento = new System.Windows.Forms.RadioButton();
            this.groupBoxBuscar.SuspendLayout();
            this.groupBoxOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPasajeros
            // 
            this.labelPasajeros.AutoSize = true;
            this.labelPasajeros.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasajeros.Location = new System.Drawing.Point(149, 20);
            this.labelPasajeros.Name = "labelPasajeros";
            this.labelPasajeros.Size = new System.Drawing.Size(210, 38);
            this.labelPasajeros.TabIndex = 0;
            this.labelPasajeros.Text = "Pasajeros";
            // 
            // lisBoxPasajeros
            // 
            this.lisBoxPasajeros.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lisBoxPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisBoxPasajeros.FormattingEnabled = true;
            this.lisBoxPasajeros.ItemHeight = 29;
            this.lisBoxPasajeros.Location = new System.Drawing.Point(41, 74);
            this.lisBoxPasajeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lisBoxPasajeros.Name = "lisBoxPasajeros";
            this.lisBoxPasajeros.ScrollAlwaysVisible = true;
            this.lisBoxPasajeros.Size = new System.Drawing.Size(723, 410);
            this.lisBoxPasajeros.TabIndex = 1;
            this.lisBoxPasajeros.SelectedIndexChanged += new System.EventHandler(this.lisBoxPasajeros_SelectedIndexChanged);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(468, 507);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(183, 60);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.radioButtonVuelo);
            this.groupBoxBuscar.Controls.Add(this.textBoxBuscar);
            this.groupBoxBuscar.Controls.Add(this.radioButtonNombre);
            this.groupBoxBuscar.Controls.Add(this.radioButtonAsiento);
            this.groupBoxBuscar.Location = new System.Drawing.Point(800, 42);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscar.Size = new System.Drawing.Size(173, 198);
            this.groupBoxBuscar.TabIndex = 9;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Busqueda";
            // 
            // radioButtonVuelo
            // 
            this.radioButtonVuelo.AutoSize = true;
            this.radioButtonVuelo.Location = new System.Drawing.Point(19, 62);
            this.radioButtonVuelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonVuelo.Name = "radioButtonVuelo";
            this.radioButtonVuelo.Size = new System.Drawing.Size(65, 21);
            this.radioButtonVuelo.TabIndex = 5;
            this.radioButtonVuelo.Text = "Vuelo";
            this.radioButtonVuelo.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(19, 114);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(135, 22);
            this.textBoxBuscar.TabIndex = 3;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Checked = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(19, 34);
            this.radioButtonNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(145, 21);
            this.radioButtonNombre.TabIndex = 4;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre o Apellido";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsiento
            // 
            this.radioButtonAsiento.AutoSize = true;
            this.radioButtonAsiento.Location = new System.Drawing.Point(19, 89);
            this.radioButtonAsiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAsiento.Name = "radioButtonAsiento";
            this.radioButtonAsiento.Size = new System.Drawing.Size(76, 21);
            this.radioButtonAsiento.TabIndex = 6;
            this.radioButtonAsiento.Text = "Asiento";
            this.radioButtonAsiento.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSize = true;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Location = new System.Drawing.Point(800, 499);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(195, 68);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // groupBoxOrdenar
            // 
            this.groupBoxOrdenar.Controls.Add(this.radioButtonOVuelo);
            this.groupBoxOrdenar.Controls.Add(this.radioButtonONombre);
            this.groupBoxOrdenar.Controls.Add(this.radioButtonOAsiento);
            this.groupBoxOrdenar.Location = new System.Drawing.Point(800, 259);
            this.groupBoxOrdenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOrdenar.Name = "groupBoxOrdenar";
            this.groupBoxOrdenar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOrdenar.Size = new System.Drawing.Size(173, 129);
            this.groupBoxOrdenar.TabIndex = 10;
            this.groupBoxOrdenar.TabStop = false;
            this.groupBoxOrdenar.Text = "Ordenar";
            // 
            // radioButtonOVuelo
            // 
            this.radioButtonOVuelo.AutoSize = true;
            this.radioButtonOVuelo.Location = new System.Drawing.Point(19, 62);
            this.radioButtonOVuelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonOVuelo.Name = "radioButtonOVuelo";
            this.radioButtonOVuelo.Size = new System.Drawing.Size(65, 21);
            this.radioButtonOVuelo.TabIndex = 5;
            this.radioButtonOVuelo.Text = "Vuelo";
            this.radioButtonOVuelo.UseVisualStyleBackColor = true;
            this.radioButtonOVuelo.CheckedChanged += new System.EventHandler(this.radioButtonOVuelo_CheckedChanged);
            // 
            // radioButtonONombre
            // 
            this.radioButtonONombre.AutoSize = true;
            this.radioButtonONombre.Location = new System.Drawing.Point(19, 34);
            this.radioButtonONombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonONombre.Name = "radioButtonONombre";
            this.radioButtonONombre.Size = new System.Drawing.Size(79, 21);
            this.radioButtonONombre.TabIndex = 4;
            this.radioButtonONombre.Text = "Nombre";
            this.radioButtonONombre.UseVisualStyleBackColor = true;
            this.radioButtonONombre.CheckedChanged += new System.EventHandler(this.radioButtonONombre_CheckedChanged);
            // 
            // radioButtonOAsiento
            // 
            this.radioButtonOAsiento.AutoSize = true;
            this.radioButtonOAsiento.Location = new System.Drawing.Point(19, 89);
            this.radioButtonOAsiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonOAsiento.Name = "radioButtonOAsiento";
            this.radioButtonOAsiento.Size = new System.Drawing.Size(76, 21);
            this.radioButtonOAsiento.TabIndex = 6;
            this.radioButtonOAsiento.Text = "Asiento";
            this.radioButtonOAsiento.UseVisualStyleBackColor = true;
            this.radioButtonOAsiento.CheckedChanged += new System.EventHandler(this.radioButtonOAsiento_CheckedChanged);
            // 
            // ventanaPasajerosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 581);
            this.Controls.Add(this.groupBoxOrdenar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.lisBoxPasajeros);
            this.Controls.Add(this.labelPasajeros);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ventanaPasajerosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasajeros";
            this.Load += new System.EventHandler(this.ventanaPasajerosForm_Load);
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.groupBoxOrdenar.ResumeLayout(false);
            this.groupBoxOrdenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPasajeros;
        private System.Windows.Forms.ListBox lisBoxPasajeros;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.RadioButton radioButtonVuelo;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.RadioButton radioButtonAsiento;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBoxOrdenar;
        private System.Windows.Forms.RadioButton radioButtonOVuelo;
        private System.Windows.Forms.RadioButton radioButtonONombre;
        private System.Windows.Forms.RadioButton radioButtonOAsiento;
    }
}