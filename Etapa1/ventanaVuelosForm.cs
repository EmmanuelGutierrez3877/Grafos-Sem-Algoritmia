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
    public partial class ventanaVuelosForm : Form
    {
        ListaVuelos lv;
        Grafo g;

        public ventanaVuelosForm(ListaVuelos lv,Grafo g)
        {
            this.g = g;
            this.lv =lv;
            InitializeComponent();
            
            actializarListBoxt(this.lv);
            
        }

        private void listBoxVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRegistrar.Enabled = true;
            buttonEliminar.Enabled = true;
        }

        private void listaVuelosLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void BotonContinuar_Click(object sender, EventArgs e)
        {
            Vuelo v = (Vuelo)lisBoxVuelos.SelectedItem;

            VentanaCompraForm objCompra = new VentanaCompraForm(v);
            objCompra.ShowDialog();
            if (objCompra.GetReg()) {
                this.Close();
            }
            
        }

        private void ventanaVuelosForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void actializarListBoxt(ListaVuelos lv) {
            lisBoxVuelos.Items.Clear();
            for (int i =0;i < lv.Count; i++)
            {
                lisBoxVuelos.Items.Add(lv[i]);
            }
            lisBoxVuelos.Refresh();
            buttonRegistrar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            ListaVuelos lvF;
            
            if (textBoxBuscar.Text == "")
            {
                actializarListBoxt(lv);
            }
            else
            {
                if (radioButtonRuta.Checked)
                {
                    lvF = lv.busquedaMultiple(1, textBoxBuscar.Text);

                }
                else if (radioButtonOrigen.Checked)
                {
                    lvF = lv.busquedaMultiple(2, textBoxBuscar.Text);

                }
                else
                {
                    lvF = lv.busquedaMultiple(3, textBoxBuscar.Text);

                }
                actializarListBoxt(lvF);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            

            lv.Remove((Vuelo)lisBoxVuelos.SelectedItem);
            g.eliminarArista((Vuelo)lisBoxVuelos.SelectedItem, lv);
            lisBoxVuelos.Items.Remove(lisBoxVuelos.SelectedItem);

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            VentanaNuevoVuelo objCompra = new VentanaNuevoVuelo(lv,g);
            objCompra.ShowDialog();
            actializarListBoxt(lv);
        }

        private void radioButtonOOrigen_CheckedChanged(object sender, EventArgs e)
        {
            lv.quickSort(0, lv.Count - 1,1);
            actializarListBoxt(this.lv);
        }

        private void radioButtonODestino_CheckedChanged(object sender, EventArgs e)
        {
            lv.quickSort(0, lv.Count - 1,2);
            actializarListBoxt(this.lv);
        }

        private void radioButtonOCosto_CheckedChanged(object sender, EventArgs e)
        {
            lv.quickSort(0, lv.Count - 1,3);
            actializarListBoxt(this.lv);
        }

        private void radioButtonOTiempo_CheckedChanged(object sender, EventArgs e)
        {
            lv.quickSort(0, lv.Count - 1,4);
            actializarListBoxt(this.lv);
        }

    }
}
