using System;
using System.Windows.Forms;

namespace Etapa6
{
    public partial class ventanaPrincipalForm : Form
    {
        ListaVuelos lv;
        Grafo g;

        public ventanaPrincipalForm(ListaVuelos lv,Grafo g)
        {
            this.g = g;
            this.lv = lv;
            InitializeComponent();
        }

        public ListaVuelos getVuelos()
        {
            return lv;
        }

        private void presentacion_Click(object sender, EventArgs e)
        {

        }

        private void botonVuelos_Click(object sender, EventArgs e)
        { 
            ventanaVuelosForm objVuelos = new ventanaVuelosForm(lv,g);
            objVuelos.ShowDialog();
        }

        private void buttonPasajeros_Click(object sender, EventArgs e)
        {
            ventanaPasajerosForm objPasajeros = new ventanaPasajerosForm(lv);
            objPasajeros.ShowDialog();
        }

        private void ventanaPrincipalForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonGrafo_Click(object sender, EventArgs e)
        {
            GrafoForm ventanaGrafo = new GrafoForm(g,lv);
            ventanaGrafo.ShowDialog();
        }

    }
}
