namespace Etapa6
{
    partial class ventanaVuelosForm
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
            this.lisBoxVuelos = new System.Windows.Forms.ListBox();
            this.listaVuelosLabel = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.radioButtonOrigen = new System.Windows.Forms.RadioButton();
            this.radioButtonDestino = new System.Windows.Forms.RadioButton();
            this.radioButtonRuta = new System.Windows.Forms.RadioButton();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.groupBoxOrdenar = new System.Windows.Forms.GroupBox();
            this.radioButtonOTiempo = new System.Windows.Forms.RadioButton();
            this.radioButtonOCosto = new System.Windows.Forms.RadioButton();
            this.radioButtonODestino = new System.Windows.Forms.RadioButton();
            this.radioButtonOOrigen = new System.Windows.Forms.RadioButton();
            this.groupBoxBuscar.SuspendLayout();
            this.groupBoxOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lisBoxVuelos
            // 
            this.lisBoxVuelos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lisBoxVuelos.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisBoxVuelos.FormattingEnabled = true;
            this.lisBoxVuelos.ItemHeight = 31;
            this.lisBoxVuelos.Location = new System.Drawing.Point(47, 85);
            this.lisBoxVuelos.Margin = new System.Windows.Forms.Padding(4);
            this.lisBoxVuelos.Name = "lisBoxVuelos";
            this.lisBoxVuelos.ScrollAlwaysVisible = true;
            this.lisBoxVuelos.Size = new System.Drawing.Size(491, 438);
            this.lisBoxVuelos.TabIndex = 0;
            this.lisBoxVuelos.SelectedIndexChanged += new System.EventHandler(this.listBoxVuelos_SelectedIndexChanged);
            // 
            // listaVuelosLabel
            // 
            this.listaVuelosLabel.AutoSize = true;
            this.listaVuelosLabel.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaVuelosLabel.Location = new System.Drawing.Point(195, 23);
            this.listaVuelosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listaVuelosLabel.Name = "listaVuelosLabel";
            this.listaVuelosLabel.Size = new System.Drawing.Size(167, 45);
            this.listaVuelosLabel.TabIndex = 1;
            this.listaVuelosLabel.Text = "Vuelos";
            this.listaVuelosLabel.Click += new System.EventHandler(this.listaVuelosLabel_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegistrar.Enabled = false;
            this.buttonRegistrar.Location = new System.Drawing.Point(565, 453);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(195, 68);
            this.buttonRegistrar.TabIndex = 2;
            this.buttonRegistrar.Text = "Registrar Pasajero";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.BotonContinuar_Click);
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
            // radioButtonOrigen
            // 
            this.radioButtonOrigen.AutoSize = true;
            this.radioButtonOrigen.Location = new System.Drawing.Point(19, 62);
            this.radioButtonOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonOrigen.Name = "radioButtonOrigen";
            this.radioButtonOrigen.Size = new System.Drawing.Size(72, 21);
            this.radioButtonOrigen.TabIndex = 4;
            this.radioButtonOrigen.TabStop = true;
            this.radioButtonOrigen.Text = "Origen";
            this.radioButtonOrigen.UseVisualStyleBackColor = true;
            // 
            // radioButtonDestino
            // 
            this.radioButtonDestino.AutoSize = true;
            this.radioButtonDestino.Location = new System.Drawing.Point(19, 89);
            this.radioButtonDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDestino.Name = "radioButtonDestino";
            this.radioButtonDestino.Size = new System.Drawing.Size(77, 21);
            this.radioButtonDestino.TabIndex = 5;
            this.radioButtonDestino.TabStop = true;
            this.radioButtonDestino.Text = "Destino";
            this.radioButtonDestino.UseVisualStyleBackColor = true;
            // 
            // radioButtonRuta
            // 
            this.radioButtonRuta.AutoSize = true;
            this.radioButtonRuta.Checked = true;
            this.radioButtonRuta.Location = new System.Drawing.Point(19, 34);
            this.radioButtonRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonRuta.Name = "radioButtonRuta";
            this.radioButtonRuta.Size = new System.Drawing.Size(59, 21);
            this.radioButtonRuta.TabIndex = 6;
            this.radioButtonRuta.TabStop = true;
            this.radioButtonRuta.Text = "Ruta";
            this.radioButtonRuta.UseVisualStyleBackColor = true;
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.radioButtonDestino);
            this.groupBoxBuscar.Controls.Add(this.textBoxBuscar);
            this.groupBoxBuscar.Controls.Add(this.radioButtonOrigen);
            this.groupBoxBuscar.Controls.Add(this.radioButtonRuta);
            this.groupBoxBuscar.Location = new System.Drawing.Point(565, 39);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscar.Size = new System.Drawing.Size(173, 198);
            this.groupBoxBuscar.TabIndex = 8;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Busqueda";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSize = true;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Location = new System.Drawing.Point(565, 265);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(195, 68);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar Vuelo";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.AutoSize = true;
            this.buttonNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonNuevo.Location = new System.Drawing.Point(565, 362);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(195, 68);
            this.buttonNuevo.TabIndex = 10;
            this.buttonNuevo.Text = "Nuevo Vuelo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // groupBoxOrdenar
            // 
            this.groupBoxOrdenar.Controls.Add(this.radioButtonOTiempo);
            this.groupBoxOrdenar.Controls.Add(this.radioButtonOCosto);
            this.groupBoxOrdenar.Controls.Add(this.radioButtonODestino);
            this.groupBoxOrdenar.Controls.Add(this.radioButtonOOrigen);
            this.groupBoxOrdenar.Location = new System.Drawing.Point(754, 39);
            this.groupBoxOrdenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOrdenar.Name = "groupBoxOrdenar";
            this.groupBoxOrdenar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOrdenar.Size = new System.Drawing.Size(126, 198);
            this.groupBoxOrdenar.TabIndex = 11;
            this.groupBoxOrdenar.TabStop = false;
            this.groupBoxOrdenar.Text = "Ordenar";
            // 
            // radioButtonOTiempo
            // 
            this.radioButtonOTiempo.AutoSize = true;
            this.radioButtonOTiempo.Location = new System.Drawing.Point(17, 114);
            this.radioButtonOTiempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonOTiempo.Name = "radioButtonOTiempo";
            this.radioButtonOTiempo.Size = new System.Drawing.Size(76, 21);
            this.radioButtonOTiempo.TabIndex = 7;
            this.radioButtonOTiempo.Text = "Tiempo";
            this.radioButtonOTiempo.UseVisualStyleBackColor = true;
            this.radioButtonOTiempo.CheckedChanged += new System.EventHandler(this.radioButtonOTiempo_CheckedChanged);
            // 
            // radioButtonOCosto
            // 
            this.radioButtonOCosto.AutoSize = true;
            this.radioButtonOCosto.Location = new System.Drawing.Point(17, 87);
            this.radioButtonOCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonOCosto.Name = "radioButtonOCosto";
            this.radioButtonOCosto.Size = new System.Drawing.Size(65, 21);
            this.radioButtonOCosto.TabIndex = 6;
            this.radioButtonOCosto.Text = "Costo";
            this.radioButtonOCosto.UseVisualStyleBackColor = true;
            this.radioButtonOCosto.CheckedChanged += new System.EventHandler(this.radioButtonOCosto_CheckedChanged);
            // 
            // radioButtonODestino
            // 
            this.radioButtonODestino.AutoSize = true;
            this.radioButtonODestino.Location = new System.Drawing.Point(17, 61);
            this.radioButtonODestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonODestino.Name = "radioButtonODestino";
            this.radioButtonODestino.Size = new System.Drawing.Size(77, 21);
            this.radioButtonODestino.TabIndex = 5;
            this.radioButtonODestino.Text = "Destino";
            this.radioButtonODestino.UseVisualStyleBackColor = true;
            this.radioButtonODestino.CheckedChanged += new System.EventHandler(this.radioButtonODestino_CheckedChanged);
            // 
            // radioButtonOOrigen
            // 
            this.radioButtonOOrigen.AutoSize = true;
            this.radioButtonOOrigen.Location = new System.Drawing.Point(17, 34);
            this.radioButtonOOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonOOrigen.Name = "radioButtonOOrigen";
            this.radioButtonOOrigen.Size = new System.Drawing.Size(72, 21);
            this.radioButtonOOrigen.TabIndex = 4;
            this.radioButtonOOrigen.Text = "Origen";
            this.radioButtonOOrigen.UseVisualStyleBackColor = true;
            this.radioButtonOOrigen.CheckedChanged += new System.EventHandler(this.radioButtonOOrigen_CheckedChanged);
            // 
            // ventanaVuelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 551);
            this.Controls.Add(this.groupBoxOrdenar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.listaVuelosLabel);
            this.Controls.Add(this.lisBoxVuelos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ventanaVuelosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.ventanaVuelosForm_Load);
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.groupBoxOrdenar.ResumeLayout(false);
            this.groupBoxOrdenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lisBoxVuelos;
        private System.Windows.Forms.Label listaVuelosLabel;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.RadioButton radioButtonOrigen;
        private System.Windows.Forms.RadioButton radioButtonDestino;
        private System.Windows.Forms.RadioButton radioButtonRuta;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.GroupBox groupBoxOrdenar;
        private System.Windows.Forms.RadioButton radioButtonODestino;
        private System.Windows.Forms.RadioButton radioButtonOOrigen;
        private System.Windows.Forms.RadioButton radioButtonOTiempo;
        private System.Windows.Forms.RadioButton radioButtonOCosto;
    }
}