using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa6
{
    [Serializable]
    public class Grafo
    {
        List<Nodo> listaNodos;

        public Grafo(ListaVuelos lv)
        {
            listaNodos = new List<Nodo>();
        
            bool existeN = false;
            foreach (Vuelo v in lv)
            {
                existeN = false;

                foreach (Nodo nAux in listaNodos)
                    if (nAux.getCiudad() == v.getOrigen())
                    {
                        existeN = true;
                        break;
                    }
                if (!existeN)
                {
                    Nodo n = new Nodo(v.getOrigen());
                    listaNodos.Add(n);

                }
            }




            existeN = false;
            foreach (Vuelo v in lv)
            {
                existeN = false;
                foreach (Nodo nAux in listaNodos)
                    if (nAux.getCiudad() == v.getDestino())
                    {
                        existeN = true;
                        break;
                    }
                if (!existeN)
                {
                    Nodo n = new Nodo(v.getDestino());
                    listaNodos.Add(n);
                }
            }



            //crea lista ady de cada nodo
            foreach (Nodo n in listaNodos)
            {
                //Console.WriteLine(n.getCiudad());
                foreach (Vuelo v in lv)
                {
                    if (v.getOrigen() == n.getCiudad())
                    {
                        foreach (Nodo nRef in listaNodos)
                        {
                            if (nRef.getCiudad() == v.getDestino())
                            {
                                Ady nuevoadyacente = new Ady(nRef, v.getCosto(),v.getTiempo());
                                n.insertaAdy(nuevoadyacente);

                            }
                        }//ref lista nodos

                    }//if

                }//foreach vuelos

            }//foreach nodos

        }

        public void agregarArista(Vuelo v)
        {
            bool ori = false, des = false;

            foreach (Nodo n in listaNodos)
            {
                if (n.getCiudad() == v.getOrigen())
                {
                    ori = true;
                }
                if (n.getCiudad() == v.getDestino())
                {
                    des = true;
                }
            }

            if (!ori)
            {
                Nodo o = new Nodo(v.getOrigen());
                listaNodos.Add(o);
            }
            if (!des)
            {
                Nodo d = new Nodo(v.getDestino());
                listaNodos.Add(d);
            }


            foreach (Nodo n in listaNodos)
            {
                if (n.getCiudad() == v.getOrigen())
                {
                    foreach (Nodo nAux in listaNodos)
                    {
                        if (nAux.getCiudad() == v.getDestino())
                        {
                            Ady a = new Ady(nAux, v.getCosto(),v.getTiempo());
                            n.getListaAdy().Add(a);
                        }
                    }
                }
            }


        }

        public void eliminarArista(Vuelo v,ListaVuelos lv) {

            bool eliminar = true,ex=false,stop = true;
            do
            {
                ex = false;
                foreach (Nodo n in listaNodos)
                {
                    foreach (Ady a in n.getListaAdy())
                    {
                        if (n.getCiudad() == v.getOrigen() && a.getNodo().getCiudad() == v.getDestino())
                        {
                            ex = true;
                            n.getListaAdy().Remove(a);
                            break;
                        }
                    }
                }
            }while(ex);

            do
            {
                stop = true;

                foreach (Nodo n in listaNodos)
                {
                    eliminar = true;
                    foreach (Vuelo vAux in lv)
                    {
                        if (n.getCiudad() == vAux.getOrigen() || n.getCiudad() == vAux.getDestino())
                        {
                            eliminar = false;
                        }
                    }

                    if (eliminar == true)
                    {
                        stop = false;
                        listaNodos.Remove(n);
                        break;
                    }
                }

            } while (!stop);
            
        }

        public List<Nodo> getListaNodos()
        {

            return listaNodos;
        }

        public void impirme()
        {
            Console.Write("\n\n");
            foreach (Nodo n in listaNodos)
            {
                Console.Write(n.getCiudad()+" -> ");
                n.imprimeLA();
                Console.Write("\n");
            }
        }

    }


    [Serializable]
    public class Nodo {
        char ciudad;
        int x=-1, y=-1;
        List<Ady> listaAdy;

        public Nodo(char c)
        {
            ciudad = c;
            listaAdy = new List<Ady>();
        }

        /*
        public void insertaAdy(Nodo n, int c)
        {
            Ady adyacente = new Ady(n, c);
            listaAdy.Add(adyacente);
        }
        */
        
        public void insertaAdy(Ady a)
        {
            this.listaAdy.Add(a);
        }
        
        public void imprimeLA()
        {
            foreach (Ady a in listaAdy)
            {
                Console.Write(a.getNodo().ciudad+ " -> ");
            }
        }

        public List<Ady> getListaAdy() {
            return listaAdy;
        }

        public char getCiudad()
        {
            return ciudad;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

    }


    [Serializable]
    public class Ady
    {
        Nodo n;
        int costo,tiempo;

        public Ady(Nodo n,int c,int t)
        {
            this.n = n;
            this.costo = c;
            this.tiempo = t;
        }

        public int getcosto()
        {
            return costo;
        }

        public int getTiempo()
        {
            return tiempo;
        }

        public Nodo getNodo() {
            return n;
        }

    }


    [Serializable]
    public class Kruscal
    {
        ListaVuelos arm = new ListaVuelos();
        ListaVuelos c = new ListaVuelos();
        List<String> cc = new List<String>();
        Grafo gk;
        int ct = 0, tt = 0;

        public Kruscal(Grafo g, ListaVuelos lv,char opc)
        {
            
            //Console.Write("\nKruscal ");
            int u1, u2;
            String v1 = "", v2 = "";
            Vuelo aux;

            foreach (Vuelo v in lv)
                c.Add(v);

            if (opc == 'c')
            {
                c.quickSort(0, c.Count - 1, 3);
                //Console.Write("costo ->");
            }
            else {
                c.quickSort(0, c.Count - 1, 4);
                //Console.Write("tiempo ->");
            }
            inicializaCC(g);
            
            
            while (c.Count > 0)
            {
                aux = seleciona(c);
                v1 = v1 + aux.getOrigen();
                v2 = v2 + aux.getDestino();

                u1 = busca(aux.getOrigen());
                u2 = busca(aux.getDestino());

                if (u1 != u2)
                {
                    combina(u1, u2);
                    arm.Add(aux);
                    ct = ct + aux.getCosto();
                    tt = tt + aux.getTiempo();

                    //Console.Write(aux.getOrigen().ToString()+aux.getDestino().ToString()+"-> ");
                }
            }
            gk = new Grafo(arm);
            
        }

        Vuelo seleciona(ListaVuelos lv)
        {
            Vuelo v = lv[0];
            lv.Remove(v);
            return v;
        }

        void inicializaCC(Grafo g)
        {
            for (int i = 0; i < g.getListaNodos().Count; i++)
            {
                cc.Add(g.getListaNodos()[i].getCiudad().ToString());
            }
        }

        void combina(int a, int b)
        {
            cc[a] = cc[a] + cc[b];
            cc.Remove(cc[b]);
        }

        int busca(char u)
        {
            for (int i = 0; i < cc.Count; i++)
            {
                if (cc[i].Contains(u))
                {
                    return i;
                }
            }

            return -1;
        }

        public Grafo getGK()
        {
            return gk;
        }

        public int getCostoTotal() {
            return ct;
        }

        public int getTiempoTotal() {
            return tt;
        }

        public ListaVuelos GetLista() {
            return arm;
        }

    }


    [Serializable]
    public class Prim
    {

        ListaVuelos vuelos = new ListaVuelos();
        ListaVuelos arm = new ListaVuelos();
        List<Nodo> Ciudades = new List<Nodo>();
        Grafo gp;
        int ct = 0, tt = 0;

        public Prim(Grafo g, ListaVuelos lv , char opc, Nodo ini)
        {
            InicializaCandidatos(lv,opc,ini);

            //while (Ciudades.Count < g.getListaNodos().Count-1)
            do
            {
                arm.Add(Selecciona(opc, Ciudades));
                if (arm[arm.Count - 1] == null) {
                    arm.Remove(arm[arm.Count-1]);

                    Ciudades.Add(new Nodo(vuelos[0].getOrigen()));
                }
            } while (vuelos.Count > 0);
            gp = new Grafo(arm);
        }
         
        void InicializaCandidatos(ListaVuelos lv,char opc,Nodo ini)
        {
            foreach (Vuelo v in lv)
            {
                //candidatos.Add(v);
                vuelos.Add(v);
            }
            
            Ciudades.Add(ini);
            //arm.Add(Selecciona(vuelos,opc,Ciudades));
        }

        Vuelo Selecciona(char opc, List<Nodo> nodos) {
            ListaVuelos candidatos = new ListaVuelos();
            Vuelo aux;
            bool stop = true;

            candidatos.Clear();

            foreach (Nodo n in nodos) {
                foreach (Vuelo v in vuelos)
                {
                    if (v.getOrigen() == n.getCiudad()||v.getDestino() == n.getCiudad())
                        candidatos.Add(v);
                }
            }

            if (candidatos.Count > 0)
            {
                if (opc == 'c')
                {
                    candidatos.quickSort(0, candidatos.Count - 1, 3);

                }
                else
                {
                    candidatos.quickSort(0, candidatos.Count - 1, 4);

                }


                aux = candidatos[0];
                this.vuelos.Remove(candidatos[0]);

                if (!Ciudades.Contains(new Nodo(aux.getOrigen())))
                {
                    Ciudades.Add(new Nodo(aux.getOrigen()));
                }

                if (!Ciudades.Contains(new Nodo(aux.getDestino())))
                {
                    Ciudades.Add(new Nodo(aux.getDestino()));
                }

                do
                {
                    stop = true;
                    foreach (Nodo n2 in Ciudades)
                    {
                        foreach (Nodo n in Ciudades)
                        {
                            foreach (Vuelo v in this.vuelos)
                            {
                                if (v.getOrigen() == n2.getCiudad() && v.getDestino() == n.getCiudad())
                                {
                                    vuelos.Remove(v);
                                    stop = false;
                                    break;
                                }
                            }
                        }
                    }
                } while (!stop);

                //Console.Write(aux.getOrigen().ToString() + aux.getDestino().ToString() + "-> ");
                tt = tt + aux.getTiempo();
                ct = ct + aux.getCosto();
                return aux;
            }
            return null;
        }

        public Grafo getGP() {
            return gp;
        }

        public int getCT() {
            return ct;
        }

        public int getTT()
        {
            return tt;
        }

        public ListaVuelos GetLista()
        {
            return arm;
        }

    }


    [Serializable]
    public class Dijkstra {

        List<ElementoDijkstra> VD = new List<ElementoDijkstra>();
        char opc;


        public Dijkstra(Grafo g,Nodo n,char opc) {
            this.opc = opc;
            int p = 0;
            ElementoDijkstra ed;

            Inicializa(g,n);
            do {
                ActualizaPesos(VD, n, g, p, opc);

                ed = sigDefinitivo(VD);
                if (ed != null)
                {
                    p = ed.getPeso();
                    n = ed.GetDes();
                }

            }while(ed != null);

        }

        public Dijkstra(Grafo g, Nodo n, char opc,Nodo f)
        {
            this.opc = opc;
            int p = 0;
            ElementoDijkstra ed;

            Inicializa(g, n,f);
            do
            {
                ActualizaPesos(VD, n, g, p, opc);

                ed = sigDefinitivo(VD);
                if (ed != null)
                {
                    p = ed.getPeso();
                    n = ed.GetDes();
                }

            } while (ed != null && !VD[0].GetDef());

        }

        void Inicializa(Grafo g,Nodo inicial) {
            foreach (Nodo n in g.getListaNodos())
            {
                if (n == inicial)
                {
                    VD.Add(new ElementoDijkstra(n, 0, true));
                }
                else
                {
                    VD.Add(new ElementoDijkstra(n, 10000, false));
                }


            }
        }

        void Inicializa(Grafo g, Nodo inicial,Nodo final)
        {
            foreach(Nodo n in g.getListaNodos())
            {
                if (n == final)
                {
                    VD.Add(new ElementoDijkstra(n, 10000, false));
                }
            }
            foreach (Nodo n in g.getListaNodos())
            {
                if (n == inicial)
                {
                    VD.Add(new ElementoDijkstra(n, 0, true));
                }
                else if(n!=final)
                {
                    VD.Add(new ElementoDijkstra(n, 10000, false));
                }
            }
        }

        void ActualizaPesos(List<ElementoDijkstra>  VD, Nodo n, Grafo g ,int p,char opc)
        {
            
            ElementoDijkstra ed;

            if (g.getListaNodos().Contains(n)) {
                foreach (Ady a in n.getListaAdy())
                {
                    ed = BuscaElementoDijkstra(VD, a);

                    if (opc == 'c')
                    {
                        if (p + a.getcosto() < ed.getPeso())
                        {
                            ed.setPeso(p + a.getcosto());
                            ed.setProv(n);
                        }
                    }
                    else
                    {
                        if (p + a.getTiempo() < ed.getPeso())
                        {
                            ed.setPeso(p + a.getTiempo());
                            ed.setProv(n);
                        }
                    }
                }
            }
            
        }

        ElementoDijkstra sigDefinitivo(List<ElementoDijkstra> VD)
        {
            ElementoDijkstra ed=new ElementoDijkstra(new Nodo(' '),10000,false);
            foreach (ElementoDijkstra e in VD) {
                if (e.GetDef()==false && e.getPeso()<ed.getPeso())
                {
                    ed = e;
                }
            }
            ed.setDef(true);

            if (ed.getPeso() != 10000)
            {
                return ed;
            }
            return null;
        }

        ElementoDijkstra BuscaElementoDijkstra(List<ElementoDijkstra> VD, Ady a)
        {
            foreach (ElementoDijkstra ed in VD) {
                if(ed.GetDes() == a.getNodo())
                {
                    return ed;
                }
            }
            return null;
        }


        public List<ElementoDijkstra> getVD()
        {
            return VD;
        }
    }

    [Serializable]
    public class ElementoDijkstra
    {
        int peso;  //peso -> ponderación
        Nodo des;                   //nodo -> referencia al destino
        bool def;    //-> bandera que indica si un camino es definitivo o no.
        Nodo prov;                  // proveniente

        public ElementoDijkstra(Nodo des,int p,bool def) {
            this.def = def;
            this.peso = p;
            this.des = des;
        }

        public String Ruta(ElementoDijkstra ed,List<ElementoDijkstra> VD) {

            String r="";

            if (ed.GetProv() != null )
            {
                r = ed.GetDes().getCiudad().ToString();
                foreach (ElementoDijkstra aux in VD)
                {
                    if (aux.GetDes()==ed.GetProv())
                    {
                        r=Ruta(aux,VD) + "->" + r;
                        break;
                    }
                }
                
            }
            else
            {
                r=ed.GetDes().getCiudad().ToString();
            }
            return r;
            
        }

        public void setProv(Nodo prov)
        {
            this.prov = prov;
        }

        public void setPeso(int peso) {
            this.peso = peso;
        }

        public void setDef(bool def)
        {
            this.def = def;
        }

        public int getPeso() {
            return peso;
        }

        public Nodo GetProv() {
            return prov;
        }

        public bool GetDef()
        {
            return def;
        }

        public Nodo GetDes()
        {
            return des;
        }
    }
}
