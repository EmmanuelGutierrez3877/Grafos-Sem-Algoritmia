using System;
using System.Collections.Generic;

namespace Etapa6
{
    [Serializable]
    public class ListaPasajeros : List<Pasajero>
    {

        public ListaPasajeros busquedaPasajeros(int opc, string dato)
        {
            ListaPasajeros lpF = new ListaPasajeros();
            dato = dato.ToUpper();
            int aux;
            switch (opc)
            {
                case 1:
                    
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < dato.Length; j++)
                            {
                                if (this[i].getNomAp()[j] != dato[j])
                                {
                                    break;
                                }
                            }
                            if (j == dato.Length)
                            {
                                lpF.Add(this[i]);
                            }
                        }
                    
                    break;

                case 2:
                    
                    for (int i = 0; i < this.Count; i++)
                    {
                        int j;
                        for (j = 0; j < dato.Length; j++)
                        {
                            if (this[i].getRuta()[j] != dato[j])
                            {
                                break;
                            }
                        }
                        if (j == dato.Length)
                        {
                            lpF.Add(this[i]);
                        }
                    }
                    break;

                case 3:
                    Int32.TryParse(dato,out aux);

                    for (int i = 0; i < this.Count; i++)
                    {
                        int j;
                        for (j = 0; j < dato.Length; j++)
                        {
                            if (this[i].getAsiento() != aux)
                            {
                                break;
                            }
                        }
                        if (j == dato.Length)
                        {
                            lpF.Add(this[i]);
                        }
                    }


                    break;
            }

            return lpF;
        }

        public void quickSort(int inicio, int fin, int opc)
        {
            int i = inicio;
            int j = fin;
            int medio = (i + j) / 2;
            Pasajero pivote = this[medio];

            do
            {
                while (this[i].compareTo(pivote, opc) == -1)
                    i++;
                while (this[j].compareTo(pivote, opc) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (inicio < j)
                quickSort(inicio, j, opc);
            if (i < fin)
                quickSort(i, fin, opc);


        }

        public void swap(int i, int j)
        {
            Pasajero aux = new Pasajero("","",0,0,"");
            aux = this[i];
            this[i] = this[j];
            this[j] = aux;
        }


    }
}
