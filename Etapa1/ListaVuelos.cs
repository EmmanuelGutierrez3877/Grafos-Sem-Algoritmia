using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa6
{
    [Serializable]
    public class ListaVuelos : List<Vuelo>
    {

        public ListaVuelos busquedaMultiple(int opc, string dato)
        {
            ListaVuelos lvF = new ListaVuelos();
            dato = dato.ToUpper();
            switch (opc)
            {
                case 1:
                    if (dato.Length <= 5)
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for ( j = 0; j < dato.Length; j++)
                            {
                                if (this[i].getRuta()[j] != dato[j])
                                {
                                    break;
                                }
                            }
                            if (j == dato.Length)
                            {
                                lvF.Add(this[i]);
                            }
                        }
                    }
                    break;

                case 2:
                    if (dato.Length <= 1)
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < dato.Length; j++)
                            {
                                if (this[i].getRuta()[3] != dato[j])
                                {
                                    break;
                                }
                            }
                            if (j == dato.Length)
                            {
                                lvF.Add(this[i]);
                            }
                        }
                    }
                    break;
                case 3:
                    if (dato.Length <= 1)
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < dato.Length; j++)
                            {
                                if (this[i].getRuta()[4] != dato[j])
                                {
                                    break;
                                }
                            }
                            if (j == dato.Length)
                            {
                                lvF.Add(this[i]);
                            }
                        }
                    }
                    break;
            }

                return lvF;
        }// busqueda

        public void setVuelo(Vuelo v,Grafo g)
        {
            this.Add(v);
            g.agregarArista(v);
        }

        public void quickSort(int inicio, int fin,int opc)
        {
            int i = inicio;
            int j = fin;
            int medio = (i + j) / 2;
            Vuelo pivote = this[medio];

            do
            {
                while (this[i].compareTo(pivote,opc) == -1)
                    i++;
                while (this[j].compareTo(pivote,opc) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (inicio < j)
                quickSort(inicio, j,opc);

            if (i < fin)
                quickSort(i, fin,opc);


        }

        public void swap(int i, int j)
        {
            Vuelo aux = new Vuelo("a","a",0,0);
            aux = this[i];
            this[i] = this[j];
            this[j] = aux;
        }

    }
}
