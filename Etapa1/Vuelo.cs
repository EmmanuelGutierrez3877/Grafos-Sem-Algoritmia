using System;

namespace Etapa6
{
    [Serializable]
    public class Vuelo
    {
        string ruta, origen, destino;
        int costo,tiempo;
        ListaPasajeros lp = new ListaPasajeros();
        

        public Vuelo(string origen, string destino, int costo, int tiempo)
        {
            
            this.origen = origen.ToUpper();
            this.destino = destino.ToUpper();
            this.costo = costo;
            this.tiempo = tiempo;
            this.ruta = "SK1" + origen.ToUpper() + destino.ToUpper();
            lp = new ListaPasajeros();

        }

        public string getRuta()
        {
            return this.ruta;
        }

        public int getCosto()
        {
            return this.costo;
        }

        public int getTiempo()
        {
            return this.tiempo;
        }

        public void setPasajero(Pasajero p)
        {
            lp.Add(p);
        }

        public override string ToString()
        {
            return ruta;
        }

        public ListaPasajeros getLp(){
            return lp;
        }

        public char getOrigen()
        {
            return ruta[3];
        }

        public char getDestino()
        {
            return ruta[4];
        }

        public int compareTo(Vuelo v,int opc)
        {
            if (opc == 1)
            {
                if (this.getOrigen() > v.getOrigen())
                    return 1;
                if (this.getOrigen() == v.getOrigen())
                    return 0;
                return -1;
            }
            else if (opc == 2)
            {
                if (this.getDestino() > v.getDestino())
                    return 1;
                if (this.getDestino() == v.getDestino())
                    return 0;
                return -1;
            }
            else if (opc == 3)
            {
                if (this.getCosto() > v.getCosto())
                    return 1;
                if (this.getCosto() == v.getCosto())
                    return 0;
                return -1;
            }
            else {
                if (this.getTiempo() > v.getTiempo())
                    return 1;
                if (this.getTiempo() == v.getTiempo())
                    return 0;
                return -1;
            }
        }

    }
    
}

