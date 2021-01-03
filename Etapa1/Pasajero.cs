using System;

namespace Etapa6
{
    [Serializable]

    public class Pasajero
    {
        string nombres, apellidos,ruta;
        int edad, asiento;

        public Pasajero(String n, string a, int e, int asiento, string ruta) {
            this.nombres = n.ToUpper();
            this.apellidos = a.ToUpper();
            this.edad = e;
            this.asiento = asiento;
            this.ruta = ruta;
        }

        public int getAsiento()
        {
            return asiento;
        }

        public string getRuta()
        {
            return ruta;
        }

        public  string getNomAp()
        {
            return nombres+"  "+apellidos;
        }

        public int compareTo(Pasajero p, int opc)
        {
            if (opc == 1)
            {
                if (String.Compare(this.getNomAp(), p.getNomAp(),true)==1)
                    return 1;
                if (this.getNomAp() == p.getNomAp())
                    return 0;
                return -1;
            }
            else if (opc == 2)
            {
                if (String.Compare(this.getRuta(), p.getRuta())==1)
                    return 1;
                if (this.getRuta() == p.getRuta())
                    return 0;
                return -1;
            }
            else
            {
                if (this.getAsiento() > p.getAsiento())
                    return 1;
                if (this.getAsiento() == p.getAsiento())
                    return 0;
                return -1;
            }
            
        }

    }
}
