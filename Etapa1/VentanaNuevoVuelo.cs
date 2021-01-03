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
    public partial class VentanaNuevoVuelo : Form
    {
        ListaVuelos lv;
        Grafo g;

        public VentanaNuevoVuelo(ListaVuelos lv,Grafo g)
        {
            this.g = g;
            this.lv = lv;
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string origen = textBoxOrigen.Text;
            string destino = textBoxDestino.Text;
            int costo = Int32.Parse(textBoxPrecio.Text);
            int tiempo = Int32.Parse(textBoxDuracion.Text);
            Vuelo v = new Vuelo(origen,destino,costo,tiempo);
            lv.setVuelo(v,g);

            this.Close();
        }

        private void Verificar()
        {
            int aux,aux2;
            string ruta;
            bool dis = true;
            ruta = "SK1"+ (textBoxOrigen.Text).ToUpper()+ (textBoxDestino.Text).ToUpper();
            if ((textBoxOrigen.Text).ToUpper()== (textBoxDestino.Text).ToUpper()) {
                dis = false;
                MessageBox.Show("Origen y destino no pueden ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Vuelo v in lv)
            {
                if (v.getRuta() == ruta)
                {
                    MessageBox.Show("Vuelo no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dis = false;
                }
            }
            if (dis==true) {
                if (textBoxOrigen.Text != "" && textBoxDestino.Text != "" && Int32.TryParse(textBoxDuracion.Text, out aux) && aux > 0 && Int32.TryParse(textBoxPrecio.Text, out aux2) && aux2 > 0)
                {
                    buttonRegistrar.Enabled = true;
                }
                else
                {
                    buttonRegistrar.Enabled = false;
                }
            }
        }

        private void textBoxOrigen_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOrigen.Text != "")
            {
                textBoxOrigen.Text = Convert.ToString(textBoxOrigen.Text[0]);
            }
            Verificar();
        }

        private void textBoxDestino_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDestino.Text != "")
            {
                textBoxDestino.Text = Convert.ToString(textBoxDestino.Text[0]);
            }
            Verificar();
        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            
                Verificar();
            
        }

        private void textBoxDuracion_TextChanged(object sender, EventArgs e)
        {
            
                Verificar();
            
        }
    }
}
