using System;
using System.Windows.Forms;

namespace Etapa6
{
    public partial class ventanaPasajerosForm : Form
    {

        ListaVuelos lv;
        ListaPasajeros lpO = new ListaPasajeros();
        ListaPasajeros lpF = new ListaPasajeros();

        public ventanaPasajerosForm(ListaVuelos lv)
        {
            this.lv = lv;
            InitializeComponent();
            cargaPasajeros(lv);
        }

        private void cargaPasajeros(ListaVuelos lv)
        {
            lpO.Clear();
            foreach (Vuelo v in lv)
            {
                foreach (Pasajero p in v.getLp())
                {
                    lpO.Add(p);
                    actializarListBoxt(lpO);
                }
            }
            lpF = lpO;
        }

        private void lisBoxPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = true;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ventanaPasajerosForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

            foreach (Vuelo v in lv)
            {
                foreach (Pasajero p in v.getLp())
                {
                    if (textBoxBuscar.Text == "")
                    {
                        actializarListBoxt(lpO);
                    }
                    else
                    {
                        if (radioButtonNombre.Checked)
                        {
                            lpF = lpO.busquedaPasajeros(1, textBoxBuscar.Text);
                        }
                        else if (radioButtonVuelo.Checked)
                        {
                            lpF = lpO.busquedaPasajeros(2, textBoxBuscar.Text);
                        }
                        else
                        {
                            lpF = lpO.busquedaPasajeros(3, textBoxBuscar.Text);
                        }
                        actializarListBoxt(lpF);
                    }

                }
            }

        }

        private void actializarListBoxt(ListaPasajeros lp)
        {   
            lisBoxPasajeros.Items.Clear();
            for (int i = 0; i < lp.Count; i++)
            {
                lisBoxPasajeros.Items.Add(lp[i].getNomAp()+"\t"+lp[i].getRuta()+"\t"+ lp[i].getAsiento());
            }
            lisBoxPasajeros.Refresh();
            buttonEliminar.Enabled = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int pos = lisBoxPasajeros.SelectedIndex;
            int aux;
            bool rompe = false;

            foreach (Vuelo v in lv)
            {
                foreach (Pasajero p in v.getLp())
                {
                    aux = p.getAsiento();

                    if(lpF[pos].getRuta() == p.getRuta() && lpF[pos].getAsiento() == p.getAsiento())
                    {
                        
                        v.getLp().Remove(p);
                        lisBoxPasajeros.Items.Remove(lisBoxPasajeros.SelectedIndex);
                        lisBoxPasajeros.Items.Clear();
                        cargaPasajeros(lv);
                        buttonEliminar.Enabled = false;
                        rompe = true;
                        break;
                    }                       
                }
                if (rompe)
                    break;

            }
            textBoxBuscar.Text = "";
            
            lisBoxPasajeros.Refresh();


            //lp.Remove((Pasajero)lisBoxPasajeros.SelectedItem.ToString());
            //lisBoxPasajeros.Items.Remove(lisBoxPasajeros.SelectedItem);
            //actializarListBoxt(lp);
        }

        private void radioButtonONombre_CheckedChanged(object sender, EventArgs e)
        {
            lpF.quickSort(0, lpF.Count - 1, 1);
            actializarListBoxt(lpF);
        }

        private void radioButtonOVuelo_CheckedChanged(object sender, EventArgs e)
        {
            lpF.quickSort(0, lpF.Count - 1, 2);
            actializarListBoxt(lpF);
        }

        private void radioButtonOAsiento_CheckedChanged(object sender, EventArgs e)
        {
            lpF.quickSort(0, lpF.Count - 1, 3);
            actializarListBoxt(lpF);
        }
    }

        
}

