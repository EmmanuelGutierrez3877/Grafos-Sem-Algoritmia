using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Etapa6
{

    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ListaVuelos lv = new ListaVuelos();

            //ListaVuelos listaVuelos;
            if (File.Exists("Vuelos.bin"))
            {
                using (Stream stream = File.Open("Vuelos.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    lv = (ListaVuelos)bformatter.Deserialize(stream);

                }
            }
            else
            {
                VuelosPrecargados();

                using (Stream sw = File.Open("Vuelos.bin", FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(sw, lv);
                    sw.Close();
                }
            }

            Grafo g = new Grafo(lv);
            g.impirme();

            //Grafo;
            if (File.Exists("Grafo.bin"))
            {
                using (Stream stream = File.Open("Grafo.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    g = (Grafo)bformatter.Deserialize(stream);

                }
            }
            else
            {

                using (Stream sw = File.Open("Grafo.bin", FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(sw, g);
                    sw.Close();
                }
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ventanaPrincipalForm());

            ventanaPrincipalForm inicio = new ventanaPrincipalForm(lv,g);
            inicio.ShowDialog();

            //AQUI GUARDAR DATOS

            File.Delete("Vuelos.bin");
            using (Stream sw = File.Create("Vuelos.bin"))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(sw, lv);
                sw.Close();
            }


            File.Delete("Grafo.bin");
            using (Stream sw = File.Create("Grafo.bin"))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(sw, g);
                sw.Close();
            }


            void VuelosPrecargados()
            {
                Vuelo v1 = new Vuelo("A", "B", 600, 50);
                Vuelo v2 = new Vuelo("A", "F", 1500, 90);
                Vuelo v3 = new Vuelo("A", "G", 1050, 80);
                Vuelo v4 = new Vuelo("B", "A", 600, 50);
                Vuelo v5 = new Vuelo("B", "C", 750, 40);
                Vuelo v6 = new Vuelo("B", "D", 650, 60);
                Vuelo v7 = new Vuelo("B", "E", 1850, 70);
                Vuelo v8 = new Vuelo("C", "B", 800, 45);
                Vuelo v9 = new Vuelo("C", "E", 850, 80);
                Vuelo v10 = new Vuelo("E", "C", 750, 45);
                Vuelo v11 = new Vuelo("E", "G", 1150, 80);
                Vuelo v12 = new Vuelo("E", "L", 1650, 60);
                Vuelo v13 = new Vuelo("E", "D", 700, 35);
                Vuelo v14 = new Vuelo("D", "E", 900, 45);
                Vuelo v15 = new Vuelo("D", "B", 700, 55);
                Vuelo v16 = new Vuelo("F", "B", 800, 65);
                Vuelo v17 = new Vuelo("F", "L", 2850, 140);
                Vuelo v18 = new Vuelo("G", "A", 1250, 95);
                Vuelo v19 = new Vuelo("G", "E", 1175, 75);
                Vuelo v20 = new Vuelo("G", "L", 2675, 135);
                Vuelo v21 = new Vuelo("G", "J", 1400, 60);
                Vuelo v22 = new Vuelo("G", "H", 450, 25);
                Vuelo v23 = new Vuelo("H", "G", 350, 30);
                Vuelo v24 = new Vuelo("H", "I", 400, 35);
                Vuelo v25 = new Vuelo("I", "H", 400, 30);
                Vuelo v26 = new Vuelo("I", "K", 400, 35);
                Vuelo v27 = new Vuelo("K", "I", 400, 35);
                Vuelo v28 = new Vuelo("K", "J", 300, 25);
                Vuelo v29 = new Vuelo("J", "L", 750, 40);
                Vuelo v30 = new Vuelo("J", "M", 1450, 70);
                Vuelo v31 = new Vuelo("L", "M", 650, 40);
                Vuelo v32 = new Vuelo("L", "K", 700, 70);
                Vuelo v33 = new Vuelo("L", "E", 1500, 60);
                Vuelo v34 = new Vuelo("M", "L", 700, 40);

                Pasajero p1 = new Pasajero("EMMANUEL", "GUTIERREZ", 20, 10, "SK1AB");
                v1.getLp().Add(p1);
                Pasajero p2 = new Pasajero("VALERIA", "RAMIREZ", 20, 12, "SK1ML");
                v34.getLp().Add(p2);
                Pasajero p3 = new Pasajero("FRANCISCO", "GARCIA", 34, 8, "SK1KI");
                v27.getLp().Add(p3);
                Pasajero p4 = new Pasajero("ALBERTO", "FONCECA", 18, 1, "SK1GJ");
                v21.getLp().Add(p4);

                lv.Add(v1);
                lv.Add(v2);
                lv.Add(v3);
                lv.Add(v4);
                lv.Add(v5);
                lv.Add(v6);
                lv.Add(v7);
                lv.Add(v8);
                lv.Add(v9);
                lv.Add(v10);
                lv.Add(v11);
                lv.Add(v12);
                lv.Add(v13);
                lv.Add(v14);
                lv.Add(v15);
                lv.Add(v16);
                lv.Add(v17);
                lv.Add(v18);
                lv.Add(v19);
                lv.Add(v20);
                lv.Add(v21);
                lv.Add(v22);
                lv.Add(v23);
                lv.Add(v24);
                lv.Add(v25);
                lv.Add(v26);
                lv.Add(v27);
                lv.Add(v28);
                lv.Add(v29);
                lv.Add(v30);
                lv.Add(v31);
                lv.Add(v32);
                lv.Add(v33);
                lv.Add(v34);

                
                
            }

        }


    }


}
