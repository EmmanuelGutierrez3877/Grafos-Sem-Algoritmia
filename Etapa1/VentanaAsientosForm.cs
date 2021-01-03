using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etapa6
{
    public partial class VentanaAsientosForm : Form
    {
        Button[] asientosButtons;
        int asientoSel;
        List<Pasajero> lp;

        public VentanaAsientosForm(List<Pasajero> lp)
        {
            this.lp = lp;
            creaAsientos();
            InitializeComponent();
        }

        private void creaAsientos()
        {
            asientosButtons = new Button[18];
            int cont = 1;
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 3; j++)
                {
                    Button bAux = new Button();
                    int h = 50;
                    int w = 70;
                    int alt = 100, anc = 400;

                    if (j == 2)
                        bAux.Location = new System.Drawing.Point(j * w + anc +40, i * h + alt);
                    else
                        bAux.Location = new System.Drawing.Point(j * w + anc, i * h + alt);


                    bAux.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                    bAux.Name = "Asiento" + cont;
                    bAux.Size = new System.Drawing.Size(w,h);
                    //baux.TabIndex = 53;
                    bAux.Text = cont.ToString();
                    bAux.BackColor = Color.Green;
                    bAux.UseVisualStyleBackColor = false;
                    bAux.Click += new System.EventHandler(this.asientosButton_Click);
                    bAux.Enabled = true;
                    this.Controls.Add(bAux);

                    asientosButtons[cont-1] = bAux;

                    cont++ ;
                }
            }

            for (int i = 0; i < lp.Count; i++)
            {
                 asientosButtons[lp[i].getAsiento()-1].BackColor=Color.Red;
                 asientosButtons[lp[i].getAsiento() - 1].Enabled = false;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void buttonFinalizar_Click(object sender, EventArgs e) { 
        
            //this.asientoSel=1;
            this.Close();
            
        }

        private void asientosButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            for(int i = 0; i<18 ;i++)
            {
                if (asientosButtons[i].Enabled == true) {
                    asientosButtons[i].BackColor = Color.Green ;
                }
            }

            b.BackColor = Color.Blue;
            asientoSel = Int32.Parse(b.Text);

        }

        public int getAsiento(){
                return asientoSel;
            
        }

        private void VentanaAsientosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
