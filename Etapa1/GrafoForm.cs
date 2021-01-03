using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Etapa6
{
    public partial class GrafoForm : Form
    {
        Grafo g,gk,gp;
        Nodo n;
        ListaVuelos lv;
        Kruscal k;
        Prim p;
        Dijkstra d;
        string ori = "";
        string des = "";

        bool pintar = false;

        public GrafoForm(Grafo g,ListaVuelos lv)
        {
            this.g = g;
            this.lv = lv;

            InitializeComponent();

        }

        private void establecerPosicion(Nodo n) {
            MessageBox.Show("Da click donde pertenere la ciudad "+n.getCiudad(), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            pintar = true;
            this.n = n;
            
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen p3 = new Pen(Color.Green, 2);
            imprimirCiudades(g,p3);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            bool pos = true;

            foreach (Nodo n in g.getListaNodos()) {

                if ( !((n.getX() <= e.X - 50 || n.getX() >= e.X + 25) || (n.getY() <= e.Y - 50 || n.getY() >= e.Y + 25))  ) {
                    pos = false;
                }
            }

            if (pintar && pos)
            {
                Pen p1 = new Pen(Color.Red, 4);
                n.setX(e.X-25);
                n.setY(e.Y-25);

                pintar = false;
            }

            Pen p3 = new Pen(Color.Green, 2);
            imprimirCiudades(g,p3);
        }

        private void imprimirCiudades(Grafo gf, Pen p3)
        {
            int x1, x2, y1, y2;
            foreach (Nodo n in gf.getListaNodos())
            {
                
                if (n.getX() >= 0 && n.getY() >= 0)
                {
                    
                    Pen p2 = new Pen(Color.Blue, 4);
                    
                    

                    panel1.CreateGraphics().DrawEllipse(p2, n.getX(), n.getY(), 50, 50);
                    panel1.CreateGraphics().DrawString(Char.ToString(n.getCiudad()), new Font("Arial", 20), new SolidBrush(Color.Blue), new RectangleF(n.getX() + 10, n.getY() + 10, 50, 50), new StringFormat());
                    
                    foreach (Ady a in n.getListaAdy())
                    {
                        if (a.getNodo().getX() >= 0 && a.getNodo().getY() >= 0)
                        {

                            if (n.getY() < a.getNodo().getY())
                            {
                                y1 = n.getY() + 40;
                                y2 = a.getNodo().getY() + 10;

                            }
                            else
                            {
                                y1 = n.getY() + 10;
                                y2 = a.getNodo().getY() + 40;

                            }

                            if (n.getX() < a.getNodo().getX())
                            {

                                x1 = n.getX() + 40;
                                x2 = a.getNodo().getX()+10;
                                panel1.CreateGraphics().DrawString(Convert.ToString("$"+a.getcosto() + "\n"+a.getTiempo() +"min."), new Font("ArialBlack", 10), new SolidBrush(Color.Black), new RectangleF(x1, y1  , 50, 50), new StringFormat());
                            }
                            else
                            {
                                x1 = n.getX()+10;
                                x2 = a.getNodo().getX()+40;
                                panel1.CreateGraphics().DrawString(Convert.ToString("$" + a.getcosto() + "\n" + a.getTiempo() + "min."), new Font("ArialBlack", 10), new SolidBrush(Color.Black), new RectangleF(x1 - 50, y1, 50, 50), new StringFormat());
                            }

                            
                            

                            AdjustableArrowCap bigArrow = new AdjustableArrowCap(7,7);
                            p3.CustomEndCap = bigArrow;
                            //panel1.CreateGraphics().DrawLine(p3,n.getX() + 25, n.getY() + 25, a.getNodo().getX() + 25, a.getNodo().getY() + 25);
                            panel1.CreateGraphics().DrawLine(p3, x1, y1, x2 ,y2);

                            

                        }
                    }
                }
            }
           

            foreach (Nodo n in gf.getListaNodos())
            {
                if (n.getX() <= 1 || n.getY() <= 1)
                {
                    
                    establecerPosicion(n);
                    break;

                }
                
            }


        }

        private void GrafoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxEliminar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Kruscal_Click(object sender, EventArgs e)
        {
            listBoxorden.Items.Clear();
            panel1.Refresh();
            if (radioButtonCosto.Checked == true)
            {
                k = new Kruscal(g, lv, 'c');
                textBoxPond.Text = "$ "+k.getCostoTotal().ToString();
            }
            else {
                k = new Kruscal(g, lv, 't');
                textBoxPond.Text =  k.getTiempoTotal().ToString()+" min.";
            }

            gk = k.getGK();

            foreach (Vuelo v in k.GetLista())
            {
                listBoxorden.Items.Add(v.getRuta());
            }

            foreach (Nodo n in g.getListaNodos()) {
                foreach (Nodo n2 in gk.getListaNodos()) {
                    if (n.getCiudad()==n2.getCiudad()) {
                        n2.setX(n.getX());
                        n2.setY(n.getY());
                    }
                }
            }
            Pen p1 = new Pen(Color.Red, 2);
            imprimirCiudades(gk, p1);
        }

        private void textBoxOrigen_TextChanged(object sender, EventArgs e)
        {
            
            char opc;

            listBoxRuta.Items.Clear();

            if (textBoxOrigen.Text != "")
            {
                ori = textBoxOrigen.Text;
                ori = ori.ToUpper();
            }
            else
            {
                ori = "";
            }


            if (radioButtonC.Checked == true)
            {
                opc = 'c';
            }
            else
            {
                opc = 't';
            }

            if (textBoxOrigen.Text != "" && textBoxDestino.Text == "" && textBoxOrigen.Text != textBoxDestino.Text)
            {
                
                foreach (Nodo n in g.getListaNodos())
                {
                    if (n.getCiudad() == ori[0])
                    {

                        d = new Dijkstra(g, n, opc);
                        foreach (ElementoDijkstra ed in d.getVD())
                        {
                            listBoxRuta.Items.Add(ed.Ruta(ed, d.getVD()));
                        }
                        break;
                    }

                }
                
                
            }
            else if (textBoxOrigen.Text != "" && textBoxDestino.Text != "")
            {
                //string aux = textBoxDestino.Text;
                //textBoxDestino.Text = aux[0]+"";
                textBoxDestino_TextChanged(sender, e);
            }
            
        }

        private void listBoxRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaVuelos vd = new ListaVuelos();
            ElementoDijkstra ed2;

            foreach (ElementoDijkstra ed in d.getVD())
            {
                if (ed == d.getVD()[listBoxRuta.SelectedIndex])
                {
                    ed2 = ed;

                    if (ed.getPeso() != 10000)
                    {
                        if (radioButtonC.Checked == true)
                        {
                            textBoxPond2.Text = "$ "+ed.getPeso().ToString();
                        }
                        else
                        {
                            textBoxPond2.Text =  ed.getPeso().ToString()+" min.";
                        }
                        
                    }
                    else
                    {
                        textBoxPond2.Text = "No disponible";
                    }

                    while (ed2.GetProv() != null) 
                    {
                        foreach (Vuelo v in lv) {
                            if (v.getOrigen() == ed2.GetProv().getCiudad() && v.getDestino()==ed2.GetDes().getCiudad())
                            {
                                vd.Add(v);
                                break;
                            }
                        }

                        foreach (ElementoDijkstra aux in d.getVD())
                        {
                            if (aux.GetDes().getCiudad() == ed2.GetProv().getCiudad())
                            {
                                ed2 = aux;
                                break;
                            }
                        }

                    }

                    break;
                }
            }
            


            Grafo gd=new Grafo(vd);
            foreach (Nodo n in g.getListaNodos())
            {
                foreach (Nodo n2 in gd.getListaNodos())
                {
                    if (n.getCiudad() == n2.getCiudad())
                    {
                        n2.setX(n.getX());
                        n2.setY(n.getY());
                    }
                }
            }
            panel1.Refresh();
            Pen p1 = new Pen(Color.Red, 2);
            imprimirCiudades(gd, p1);
        }

        private void listBoxRuta_DoubleClick(object sender, EventArgs e)
        {
            ListaVuelos vd = new ListaVuelos();
            ElementoDijkstra ed2;

            if (listBoxRuta.SelectedItem != null) {

                foreach (ElementoDijkstra ed in d.getVD())
                {
                    if (ed == d.getVD()[listBoxRuta.SelectedIndex])
                    {
                        ed2 = ed;

                        while (ed2.GetProv() != null)
                        {
                            foreach (Vuelo v in lv)
                            {
                                if (v.getOrigen() == ed2.GetProv().getCiudad() && v.getDestino() == ed2.GetDes().getCiudad())
                                {
                                    vd.Add(v);
                                    break;
                                }
                            }

                            foreach (ElementoDijkstra aux in d.getVD())
                            {
                                if (aux.GetDes().getCiudad() == ed2.GetProv().getCiudad())
                                {
                                    ed2 = aux;
                                    break;
                                }
                            }

                        }

                        break;
                    }
                }

                String nombre = "@";
                String apellido = "";
                int edad = 0;
                foreach (Vuelo v in vd)
                {
                    if (nombre == "@")
                    {
                        VentanaCompraForm compra = new VentanaCompraForm(v);
                        compra.ShowDialog();
                        nombre = compra.getNom();
                        apellido = compra.getApe();
                        edad = compra.getEdad();
                    }
                    else
                    {
                        VentanaCompraForm compra = new VentanaCompraForm(v, nombre, apellido, edad);
                        compra.ShowDialog();
                    }
                }

            }

            
        }

        private void radioButtonC_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonT_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOrigen.Text = "";
            textBoxDestino.Text = "";
            listBoxRuta.Items.Clear();
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOrigen.Text = "";
            textBoxDestino.Text = "";
            listBoxRuta.Items.Clear();
        }

        private void textBoxDestino_TextChanged(object sender, EventArgs e)
        {
            char opc;

            listBoxRuta.Items.Clear();

            if (textBoxDestino.Text != "")
            {
                des = textBoxDestino.Text;
                des = des.ToUpper();
            }
            else
            {
                des = "";
            }


            if (radioButtonC.Checked == true)
            {
                opc = 'c';
            }
            else
            {
                opc = 't';
            }

            if (textBoxDestino.Text != "" && textBoxOrigen.Text != "" && textBoxOrigen.Text != textBoxDestino.Text)
            {

                foreach (Nodo n in g.getListaNodos())
                {
                    if (n.getCiudad() == ori[0])
                    {
                        foreach (Nodo n2 in g.getListaNodos())
                        {
                            if (n2.getCiudad() == des[0])
                            {

                                d = new Dijkstra(g, n, opc, n2);


                                listBoxRuta.Items.Add(d.getVD()[0].Ruta(d.getVD()[0], d.getVD()));

                                break;
                            }

                        }
                        break;
                    }
                }
            }
        }

        private void buttonPrim_Click(object sender, EventArgs e)
        {
            Nodo ini = new Nodo(' ') ;
            
            string ciu;
            ciu = textBoxInicial.Text;
            ciu = ciu.ToUpper();

            

            if (textBoxInicial.Text != "")
            {

                foreach (Nodo n in g.getListaNodos())
                {
                    if (n.getCiudad() == ciu[0])
                    {
                        ini = n;
                        break;
                    }
                }
            }
            
                listBoxorden.Items.Clear();
                panel1.Refresh();
                if (radioButtonCosto.Checked == true)
                {
                    //Console.Write("\nPrim Costo  ");
                    p = new Prim(g, lv, 'c', ini);
                    textBoxPond.Text = "$ " + p.getCT().ToString();
                }
                else
                {
                    //Console.Write("\nPrim Tiempo ");
                    p = new Prim(g, lv, 't', ini);
                    textBoxPond.Text = p.getTT().ToString() + " min.";
                }

                gp = p.getGP();

                foreach (Vuelo v in p.GetLista())
                {
                    listBoxorden.Items.Add(v.getRuta());
                }


                foreach (Nodo n in g.getListaNodos())
                {
                    foreach (Nodo n2 in gp.getListaNodos())
                    {
                        if (n.getCiudad() == n2.getCiudad())
                        {
                            n2.setX(n.getX());
                            n2.setY(n.getY());
                        }
                    }
                }

                Pen p1 = new Pen(Color.Red, 2);
                imprimirCiudades(gp, p1);

            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string elim;
            elim= textBoxEliminar.Text;
            elim = elim.ToUpper();
            bool parar;

            listBoxorden.Items.Clear();
            listBoxRuta.Items.Clear();

            if (elim != "")
            {
                do
                {
                    parar = true;
                    

                    foreach (Vuelo v in lv)
                    {
                        if (v.getOrigen() == elim[0] || v.getDestino() == elim[0])
                        {
                            lv.Remove(v);
                            g.eliminarArista(v, lv);
                            parar = false;
                            break;
                        }
                    }
                    

                } while (!parar);

                /*
                do
                {
                    parar = true;
                    foreach (Nodo n in g.getListaNodos())
                    {
                        if (n.getListaAdy().Count > 0)
                        {
                            g.getListaNodos().Remove(n);
                            parar = false;
                            break;
                        }
                    }
                } while (!parar);
                
                 */
                 

                /*
                do
                {
                    parar = true;
                    foreach (Nodo n in g.getListaNodos())
                    {
                        if (n.getCiudad() == elim[0])
                        {

                            foreach (Vuelo v2 in lv)
                            {
                                if (v2.getOrigen() == n.getCiudad() || v2.getDestino() == n.getCiudad())
                                {
                                    g.eliminarArista(v2, lv);
                                }
                            }
                            g.getListaNodos().Remove(n);
                            parar = false;
                            break;
                        }
                    }
                } while (!parar);


                */

                panel1.Refresh();


            }
        }
    }
}
