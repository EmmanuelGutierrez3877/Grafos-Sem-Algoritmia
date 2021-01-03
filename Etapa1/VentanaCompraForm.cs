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
    public partial class VentanaCompraForm : Form
    {
        bool Reg;
        Vuelo vueloAct;

        public VentanaCompraForm(Vuelo vuelo)
        {
            
            Reg = false;
            vueloAct = vuelo;
            InitializeComponent();
            textBoxVuelo.Text = vuelo.ToString();
            textBoxPrecio.Text = vuelo.getCosto().ToString();
        }

        public VentanaCompraForm(Vuelo vuelo,String n, string a, int e) {
            Reg = false;
            vueloAct = vuelo;
            InitializeComponent();
            textBoxVuelo.Text = vuelo.ToString();
            textBoxPrecio.Text = vuelo.getCosto().ToString();

            textBoxNombre.Text = n;
            textBoxNombre.Enabled = false;
            textBoxApellido.Text = a;
            textBoxApellido.Enabled = false;
            textBoxEdad.Text = e.ToString();
            textBoxEdad.Enabled = false;
        }

        public String getNom()
        {
            return textBoxNombre.Text;
        }

        public String getApe()
        {
            return textBoxApellido.Text;
        }

        public int getEdad()
        {
            String aux = textBoxEdad.Text;
            int x;
            Int32.TryParse(aux, out x);
            return x;
        }

        private void buttonAsientos_Click(object sender, EventArgs e)
        {
            VentanaAsientosForm objAsientos = new VentanaAsientosForm(vueloAct.getLp());
            objAsientos.ShowDialog();
            textBoxAsiento.Text = objAsientos.getAsiento().ToString();
            
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            int edad = Int32.Parse(textBoxEdad.Text);

            Pasajero p = new Pasajero(nombre,apellido,edad,Int32.Parse(textBoxAsiento.Text),textBoxVuelo.Text);

            vueloAct.setPasajero(p);
            Reg = true;
            this.Close();
        }

        public bool GetReg() {
            return Reg;
        }

        private void VentanaCompraForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAsiento_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Verificar() {
            int aux;

            if (textBoxAsiento.Text=="0")
            {
                textBoxAsiento.Text = "";
            }
            if (textBoxAsiento.Text != "" && textBoxNombre.Text != "" && textBoxApellido.Text != "" && textBoxEdad.Text != "" && Int32.TryParse(textBoxEdad.Text,out aux)&& aux > 0 && aux <= 100)
            {
                buttonRegistrar.Enabled = true;
            }
            else
            {
                buttonRegistrar.Enabled = false;
            }

        }


    }
}
