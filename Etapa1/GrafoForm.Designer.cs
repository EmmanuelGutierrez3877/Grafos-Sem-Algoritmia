namespace Etapa6
{
    partial class GrafoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxEliminar = new System.Windows.Forms.TextBox();
            this.Kruscal = new System.Windows.Forms.Button();
            this.groupBoxARM = new System.Windows.Forms.GroupBox();
            this.textBoxInicial = new System.Windows.Forms.TextBox();
            this.buttonPrim = new System.Windows.Forms.Button();
            this.textBoxPond = new System.Windows.Forms.TextBox();
            this.radioButtonTiempo = new System.Windows.Forms.RadioButton();
            this.radioButtonCosto = new System.Windows.Forms.RadioButton();
            this.listBoxorden = new System.Windows.Forms.ListBox();
            this.groupBoxDijkstra = new System.Windows.Forms.GroupBox();
            this.textBoxPond2 = new System.Windows.Forms.TextBox();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.radioButtonT = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.listBoxRuta = new System.Windows.Forms.ListBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.groupBoxBuscar.SuspendLayout();
            this.groupBoxARM.SuspendLayout();
            this.groupBoxDijkstra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 666);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.buttonEliminar);
            this.groupBoxBuscar.Controls.Add(this.textBoxEliminar);
            this.groupBoxBuscar.Location = new System.Drawing.Point(939, 12);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscar.Size = new System.Drawing.Size(173, 127);
            this.groupBoxBuscar.TabIndex = 9;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Eliminar";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(41, 77);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxEliminar
            // 
            this.textBoxEliminar.Location = new System.Drawing.Point(18, 33);
            this.textBoxEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEliminar.Name = "textBoxEliminar";
            this.textBoxEliminar.Size = new System.Drawing.Size(131, 22);
            this.textBoxEliminar.TabIndex = 3;
            this.textBoxEliminar.TextChanged += new System.EventHandler(this.textBoxEliminar_TextChanged);
            // 
            // Kruscal
            // 
            this.Kruscal.Location = new System.Drawing.Point(41, 146);
            this.Kruscal.Name = "Kruscal";
            this.Kruscal.Size = new System.Drawing.Size(75, 23);
            this.Kruscal.TabIndex = 10;
            this.Kruscal.Text = "Kruscal";
            this.Kruscal.UseVisualStyleBackColor = true;
            this.Kruscal.Click += new System.EventHandler(this.Kruscal_Click);
            // 
            // groupBoxARM
            // 
            this.groupBoxARM.Controls.Add(this.textBoxInicial);
            this.groupBoxARM.Controls.Add(this.buttonPrim);
            this.groupBoxARM.Controls.Add(this.textBoxPond);
            this.groupBoxARM.Controls.Add(this.radioButtonTiempo);
            this.groupBoxARM.Controls.Add(this.radioButtonCosto);
            this.groupBoxARM.Controls.Add(this.Kruscal);
            this.groupBoxARM.Location = new System.Drawing.Point(939, 154);
            this.groupBoxARM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxARM.Name = "groupBoxARM";
            this.groupBoxARM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxARM.Size = new System.Drawing.Size(173, 278);
            this.groupBoxARM.TabIndex = 11;
            this.groupBoxARM.TabStop = false;
            this.groupBoxARM.Text = "ARM";
            // 
            // textBoxInicial
            // 
            this.textBoxInicial.Location = new System.Drawing.Point(18, 188);
            this.textBoxInicial.Name = "textBoxInicial";
            this.textBoxInicial.Size = new System.Drawing.Size(134, 22);
            this.textBoxInicial.TabIndex = 15;
            // 
            // buttonPrim
            // 
            this.buttonPrim.Location = new System.Drawing.Point(42, 216);
            this.buttonPrim.Name = "buttonPrim";
            this.buttonPrim.Size = new System.Drawing.Size(75, 23);
            this.buttonPrim.TabIndex = 14;
            this.buttonPrim.Text = "Prim";
            this.buttonPrim.UseVisualStyleBackColor = true;
            this.buttonPrim.Click += new System.EventHandler(this.buttonPrim_Click);
            // 
            // textBoxPond
            // 
            this.textBoxPond.Enabled = false;
            this.textBoxPond.Location = new System.Drawing.Point(21, 102);
            this.textBoxPond.Name = "textBoxPond";
            this.textBoxPond.Size = new System.Drawing.Size(127, 22);
            this.textBoxPond.TabIndex = 13;
            // 
            // radioButtonTiempo
            // 
            this.radioButtonTiempo.AutoSize = true;
            this.radioButtonTiempo.Location = new System.Drawing.Point(41, 66);
            this.radioButtonTiempo.Name = "radioButtonTiempo";
            this.radioButtonTiempo.Size = new System.Drawing.Size(76, 21);
            this.radioButtonTiempo.TabIndex = 12;
            this.radioButtonTiempo.Text = "Tiempo";
            this.radioButtonTiempo.UseVisualStyleBackColor = true;
            // 
            // radioButtonCosto
            // 
            this.radioButtonCosto.AutoSize = true;
            this.radioButtonCosto.Checked = true;
            this.radioButtonCosto.Location = new System.Drawing.Point(41, 29);
            this.radioButtonCosto.Name = "radioButtonCosto";
            this.radioButtonCosto.Size = new System.Drawing.Size(65, 21);
            this.radioButtonCosto.TabIndex = 11;
            this.radioButtonCosto.TabStop = true;
            this.radioButtonCosto.Text = "Costo";
            this.radioButtonCosto.UseVisualStyleBackColor = true;
            // 
            // listBoxorden
            // 
            this.listBoxorden.FormattingEnabled = true;
            this.listBoxorden.ItemHeight = 16;
            this.listBoxorden.Location = new System.Drawing.Point(944, 447);
            this.listBoxorden.Name = "listBoxorden";
            this.listBoxorden.Size = new System.Drawing.Size(168, 228);
            this.listBoxorden.TabIndex = 12;
            // 
            // groupBoxDijkstra
            // 
            this.groupBoxDijkstra.Controls.Add(this.labelDestino);
            this.groupBoxDijkstra.Controls.Add(this.textBoxDestino);
            this.groupBoxDijkstra.Controls.Add(this.textBoxPond2);
            this.groupBoxDijkstra.Controls.Add(this.labelOrigen);
            this.groupBoxDijkstra.Controls.Add(this.textBoxOrigen);
            this.groupBoxDijkstra.Controls.Add(this.radioButtonT);
            this.groupBoxDijkstra.Controls.Add(this.radioButtonC);
            this.groupBoxDijkstra.Location = new System.Drawing.Point(1118, 154);
            this.groupBoxDijkstra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDijkstra.Name = "groupBoxDijkstra";
            this.groupBoxDijkstra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDijkstra.Size = new System.Drawing.Size(173, 278);
            this.groupBoxDijkstra.TabIndex = 13;
            this.groupBoxDijkstra.TabStop = false;
            this.groupBoxDijkstra.Text = "DIJKSTRA";
            // 
            // textBoxPond2
            // 
            this.textBoxPond2.Enabled = false;
            this.textBoxPond2.Location = new System.Drawing.Point(19, 102);
            this.textBoxPond2.Name = "textBoxPond2";
            this.textBoxPond2.Size = new System.Drawing.Size(127, 22);
            this.textBoxPond2.TabIndex = 16;
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(16, 146);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(55, 17);
            this.labelOrigen.TabIndex = 15;
            this.labelOrigen.Text = "Origen:";
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Location = new System.Drawing.Point(19, 175);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(127, 22);
            this.textBoxOrigen.TabIndex = 13;
            this.textBoxOrigen.TextChanged += new System.EventHandler(this.textBoxOrigen_TextChanged);
            // 
            // radioButtonT
            // 
            this.radioButtonT.AutoSize = true;
            this.radioButtonT.Location = new System.Drawing.Point(41, 66);
            this.radioButtonT.Name = "radioButtonT";
            this.radioButtonT.Size = new System.Drawing.Size(76, 21);
            this.radioButtonT.TabIndex = 12;
            this.radioButtonT.Text = "Tiempo";
            this.radioButtonT.UseVisualStyleBackColor = true;
            this.radioButtonT.CheckedChanged += new System.EventHandler(this.radioButtonT_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Checked = true;
            this.radioButtonC.Location = new System.Drawing.Point(41, 29);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(65, 21);
            this.radioButtonC.TabIndex = 11;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "Costo";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            this.radioButtonC.MouseCaptureChanged += new System.EventHandler(this.radioButtonC_MouseCaptureChanged);
            // 
            // listBoxRuta
            // 
            this.listBoxRuta.FormattingEnabled = true;
            this.listBoxRuta.ItemHeight = 16;
            this.listBoxRuta.Location = new System.Drawing.Point(1118, 447);
            this.listBoxRuta.Name = "listBoxRuta";
            this.listBoxRuta.Size = new System.Drawing.Size(168, 228);
            this.listBoxRuta.TabIndex = 14;
            this.listBoxRuta.SelectedIndexChanged += new System.EventHandler(this.listBoxRuta_SelectedIndexChanged);
            this.listBoxRuta.DoubleClick += new System.EventHandler(this.listBoxRuta_DoubleClick);
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(16, 216);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(60, 17);
            this.labelDestino.TabIndex = 18;
            this.labelDestino.Text = "Destino:";
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(19, 245);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(127, 22);
            this.textBoxDestino.TabIndex = 17;
            this.textBoxDestino.TextChanged += new System.EventHandler(this.textBoxDestino_TextChanged);
            // 
            // GrafoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 690);
            this.Controls.Add(this.listBoxRuta);
            this.Controls.Add(this.groupBoxDijkstra);
            this.Controls.Add(this.listBoxorden);
            this.Controls.Add(this.groupBoxARM);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.panel1);
            this.Name = "GrafoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Grafo";
            this.Load += new System.EventHandler(this.GrafoForm_Load);
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.groupBoxARM.ResumeLayout(false);
            this.groupBoxARM.PerformLayout();
            this.groupBoxDijkstra.ResumeLayout(false);
            this.groupBoxDijkstra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.TextBox textBoxEliminar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button Kruscal;
        private System.Windows.Forms.GroupBox groupBoxARM;
        private System.Windows.Forms.RadioButton radioButtonTiempo;
        private System.Windows.Forms.RadioButton radioButtonCosto;
        private System.Windows.Forms.TextBox textBoxPond;
        private System.Windows.Forms.TextBox textBoxInicial;
        private System.Windows.Forms.Button buttonPrim;
        private System.Windows.Forms.ListBox listBoxorden;
        private System.Windows.Forms.GroupBox groupBoxDijkstra;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.RadioButton radioButtonT;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.ListBox listBoxRuta;
        private System.Windows.Forms.TextBox textBoxPond2;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.TextBox textBoxDestino;
    }
}