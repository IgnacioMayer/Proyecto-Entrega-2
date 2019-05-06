using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Terreno Vegetación = new Terreno("Vegetacn");
            Terreno Acuático = new Terreno("Acuatico");
            Terreno Desierto = new Terreno("Desierto");
            Terreno Nieve = new Terreno("NieveIce");
            Terreno Volcán = new Terreno("Volcanic");

            Console.WriteLine("-=Bienvenido a Bitmonlandia=-\nTerrenos:\nVegetación");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Acuático");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Desierto");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Nieve");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Volcán");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Bitmons\nTaplan");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wetar");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gofue");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Dorvalo\n-\nDoti");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ent");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Seleccione configuración inicial.\nOpción 1:");
            
            // Creamos la matriz de terrenos predefinida
            Terreno[,] opcion1 = new Terreno[10, 10];
            opcion1[0, 0] = Desierto;
            opcion1[1, 0] = Desierto;
            opcion1[1, 1] = Desierto;
            opcion1[1, 2] = Desierto;
            opcion1[1, 3] = Desierto;
            opcion1[1, 4] = Desierto;
            opcion1[1, 5] = Desierto;
            opcion1[1, 6] = Desierto;
            opcion1[2, 3] = Desierto;
            opcion1[2, 4] = Desierto;
            opcion1[2, 5] = Desierto;
            opcion1[2, 6] = Desierto;
            opcion1[2, 7] = Desierto;
            opcion1[3, 6] = Desierto;
            opcion1[3, 7] = Desierto;
            opcion1[3, 8] = Desierto;
            opcion1[3, 9] = Desierto;
            opcion1[4, 5] = Desierto;
            opcion1[4, 6] = Desierto;
            opcion1[4, 7] = Desierto;
            opcion1[4, 8] = Desierto;
            opcion1[4, 9] = Desierto;
            opcion1[5, 6] = Desierto;
            opcion1[5, 8] = Desierto;
            opcion1[0, 1] = Acuático;
            opcion1[0, 1] = Acuático;
            opcion1[0, 2] = Acuático;
            opcion1[0, 3] = Acuático;
            opcion1[0, 4] = Acuático;
            opcion1[0, 5] = Acuático;
            opcion1[5, 7] = Acuático;
            opcion1[5, 9] = Acuático;
            opcion1[6, 5] = Acuático;
            opcion1[6, 6] = Acuático;
            opcion1[6, 7] = Acuático;
            opcion1[6, 8] = Acuático;
            opcion1[6, 9] = Acuático;
            opcion1[7, 1] = Acuático;
            opcion1[7, 4] = Acuático;
            opcion1[7, 5] = Acuático;
            opcion1[7, 9] = Acuático;
            opcion1[8, 0] = Acuático;
            opcion1[8, 1] = Acuático;
            opcion1[8, 2] = Acuático;
            opcion1[8, 3] = Acuático;
            opcion1[8, 4] = Acuático;
            opcion1[9, 0] = Acuático;
            opcion1[9, 1] = Acuático;
            opcion1[9, 2] = Acuático;
            opcion1[9, 3] = Acuático;
            opcion1[0, 6] = Nieve;
            opcion1[0, 7] = Nieve;
            opcion1[0, 8] = Nieve;
            opcion1[0, 9] = Nieve;
            opcion1[1, 7] = Nieve;
            opcion1[1, 8] = Nieve;
            opcion1[1, 9] = Nieve;
            opcion1[2, 8] = Nieve;
            opcion1[2, 9] = Nieve;
            opcion1[2, 0] = Vegetación;
            opcion1[2, 1] = Vegetación;
            opcion1[2, 2] = Vegetación;
            opcion1[3, 0] = Vegetación;
            opcion1[3, 1] = Vegetación;
            opcion1[3, 2] = Vegetación;
            opcion1[3, 3] = Vegetación;
            opcion1[3, 4] = Vegetación;
            opcion1[3, 5] = Vegetación;
            opcion1[4, 0] = Vegetación;
            opcion1[4, 1] = Vegetación;
            opcion1[4, 2] = Vegetación;
            opcion1[4, 3] = Vegetación;
            opcion1[4, 4] = Vegetación;
            opcion1[5, 0] = Vegetación;
            opcion1[5, 1] = Vegetación;
            opcion1[5, 2] = Vegetación;
            opcion1[5, 3] = Vegetación;
            opcion1[5, 4] = Vegetación;
            opcion1[5, 5] = Vegetación;
            opcion1[6, 0] = Vegetación;
            opcion1[6, 1] = Vegetación;
            opcion1[6, 2] = Vegetación;
            opcion1[6, 3] = Vegetación;
            opcion1[6, 4] = Vegetación;
            opcion1[7, 0] = Vegetación;
            opcion1[7, 2] = Vegetación;
            opcion1[7, 3] = Vegetación;
            opcion1[7, 6] = Volcán;
            opcion1[7, 7] = Volcán;
            opcion1[7, 8] = Volcán;
            opcion1[8, 5] = Volcán;
            opcion1[8, 6] = Volcán;
            opcion1[8, 7] = Volcán;
            opcion1[8, 8] = Volcán;
            opcion1[8, 9] = Volcán;
            opcion1[9, 4] = Volcán;
            opcion1[9, 5] = Volcán;
            opcion1[9, 6] = Volcán;
            opcion1[9, 7] = Volcán;
            opcion1[9, 8] = Volcán; 
            opcion1[9, 9] = Volcán;

            //Creamos la poblacion inicial de Bitmon

            //Poblacion inicial de Taplan
            int[] pos1 = { 2, 2 };
            Taplan taplan1 = new Taplan(pos1);
            int[] pos2 = { 4, 1 };
            Taplan taplan2 = new Taplan(pos2);
            int[] pos3 = { 4, 2 };
            Taplan taplan3 = new Taplan(pos3);
            int[] pos4 = { 5, 3 };
            Taplan taplan4 = new Taplan(pos4);
            int[] pos5 = { 6, 0 };
            Taplan taplan5 = new Taplan(pos5);

            //Poblacion inicial de Ents
            int[] pos6 = { 2, 4 };
            Ent Ent1 = new Ent(pos6);
            int[] pos7 = { 0, 9 };
            Ent Ent2 = new Ent(pos7);
            int[] pos8 = { 3, 9 };
            Ent Ent3 = new Ent(pos8);
            int[] pos9 = { 4, 4 };
            Ent Ent4 = new Ent(pos9);

            //Poblacion inicial de Wetar
            int[] pos10 = { 0, 5 };
            Wetar Wetar1 = new Wetar(pos10);
            int[] pos11 = { 2, 3 };
            Wetar Wetar2 = new Wetar(pos11);
            int[] pos12 = { 2, 6 };
            Wetar Wetar3 = new Wetar(pos12);

            //Poblacion inicial de Gofue
            int[] pos13 = { 1, 7 };
            Gofue Gofue1 = new Gofue(pos13);
            int[] pos14 = { 7, 7 };
            Gofue Gofue2 = new Gofue(pos14);
            int[] pos15 = { 9, 5 };
            Gofue Gofue3 = new Gofue(pos15);

            //Poblacion inicial Dorvalo
            int[] pos16 = { 1, 7 };
            Dorvalo Dorvalo1 = new Dorvalo(pos16);
            int[] pos17 = { 3, 7 };
            Dorvalo Dorvalo2 = new Dorvalo(pos17);
            int[] pos18 = { 2, 7 };
            Dorvalo Dorvalo3 = new Dorvalo(pos18);

            //Poblacion inicial Doti
            int[] pos19 = { 1, 5 };
            Doti Doti1 = new Doti(pos19);
            int[] pos20 = { 9, 7 };
            Doti Doti2 = new Doti(pos20);
            int[] pos21 = { 0, 0 };
            Doti Doti3 = new Doti(pos21);
            int[] pos22 = { 5, 7 };
            Doti Doti4 = new Doti(pos22);

            List<Bitmon> bitmons1 = new List<Bitmon>();
            bitmons1.Add(taplan1);
            bitmons1.Add(taplan2);
            bitmons1.Add(taplan3);
            bitmons1.Add(taplan4);
            bitmons1.Add(taplan5);
            bitmons1.Add(Ent1);
            bitmons1.Add(Ent2);
            bitmons1.Add(Ent3);
            bitmons1.Add(Ent4);
            bitmons1.Add(Wetar1);
            bitmons1.Add(Wetar2);
            bitmons1.Add(Wetar3);
            bitmons1.Add(Gofue1);
            bitmons1.Add(Gofue2);
            bitmons1.Add(Gofue3);
            bitmons1.Add(Dorvalo1);
            bitmons1.Add(Dorvalo2);
            bitmons1.Add(Dorvalo3);
            bitmons1.Add(Doti1);
            bitmons1.Add(Doti2);
            bitmons1.Add(Doti3);
            bitmons1.Add(Doti4);

            //AGREGAMOS LA POBLACION INICIAL AL MAPA OPCION 1
            Mapa mapa1 = new Mapa();
            mapa1.Alto = 10;
            mapa1.Ancho = 10;
            mapa1.Terrenos = opcion1;
            mapa1.Bitmons = bitmons1;
            mapa1.Actualizar_espacios();
            mapa1.CrearMapa();
            Console.WriteLine("vacios");
            foreach(var espacios in mapa1.Espacios_vacios)
            {
                Console.WriteLine(espacios[0]+","+ espacios[1]);
            }
            Console.WriteLine("tiene 1");
            foreach(var espacios in mapa1.Espacios_1)
            {
                Console.WriteLine(espacios[0] + "," + espacios[1]);
            }
            Console.WriteLine("tiene 2");
            foreach(var espacios in mapa1.Espacios_2)
            {
                Console.WriteLine(espacios[0] + "," + espacios[1]);

            }


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Opción 2:");
            Terreno[,] opcion2 = new Terreno[7, 7];
            opcion2[0, 0] = Nieve;
            opcion2[0, 1] = Acuático;
            opcion2[0, 2] = Desierto;
            opcion2[0, 3] = Desierto;
            opcion2[0, 4] = Desierto;
            opcion2[0, 5] = Acuático;
            opcion2[0, 6] = Nieve;
            opcion2[1, 0] = Acuático;
            opcion2[1, 1] = Acuático;
            opcion2[1, 2] = Vegetación;
            opcion2[1, 3] = Vegetación;
            opcion2[1, 4] = Vegetación;
            opcion2[1, 5] = Acuático;
            opcion2[1, 6] = Acuático;
            opcion2[2, 0] = Desierto;
            opcion2[2, 1] = Vegetación;
            opcion2[2, 2] = Vegetación;
            opcion2[2, 3] = Volcán;
            opcion2[2, 4] = Vegetación;
            opcion2[2, 5] = Vegetación;
            opcion2[2, 6] = Desierto;
            opcion2[3, 0] = Desierto;
            opcion2[3, 1] = Vegetación;
            opcion2[3, 2] = Volcán;
            opcion2[3, 3] = Volcán;
            opcion2[3, 4] = Volcán;
            opcion2[3, 5] = Vegetación;
            opcion2[3, 6] = Desierto;
            opcion2[4, 0] = Desierto;
            opcion2[4, 1] = Vegetación;
            opcion2[4, 2] = Vegetación;
            opcion2[4, 3] = Volcán;
            opcion2[4, 4] = Vegetación;
            opcion2[4, 5] = Vegetación;
            opcion2[4, 6] = Desierto;
            opcion2[5, 0] = Acuático;
            opcion2[5, 1] = Acuático;
            opcion2[5, 2] = Vegetación;
            opcion2[5, 3] = Vegetación;
            opcion2[5, 4] = Vegetación;
            opcion2[5, 5] = Acuático;
            opcion2[5, 6] = Acuático;
            opcion2[6, 0] = Nieve;
            opcion2[6, 1] = Acuático;
            opcion2[6, 2] = Desierto;
            opcion2[6, 3] = Desierto;
            opcion2[6, 4] = Desierto;
            opcion2[6, 5] = Acuático;
            opcion2[6, 6] = Nieve;
           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Opción 3:");
            Terreno[,] opcion3 = new Terreno[6, 6];
            opcion3[0, 0] = Acuático;
            opcion3[0, 1] = Vegetación;
            opcion3[0, 2] = Vegetación;
            opcion3[0, 3] = Vegetación;
            opcion3[0, 4] = Vegetación;
            opcion3[0, 5] = Desierto;
            opcion3[1, 0] = Acuático;
            opcion3[1, 1] = Vegetación;
            opcion3[1, 2] = Volcán;
            opcion3[1, 3] = Volcán;
            opcion3[1, 4] = Volcán;
            opcion3[1, 5] = Desierto;
            opcion3[2, 0] = Acuático;
            opcion3[2, 1] = Vegetación;
            opcion3[2, 2] = Volcán;
            opcion3[2, 3] = Nieve;
            opcion3[2, 4] = Volcán;
            opcion3[2, 5] = Desierto;
            opcion3[3, 0] = Acuático;
            opcion3[3, 1] = Vegetación;
            opcion3[3, 2] = Volcán;
            opcion3[3, 3] = Volcán;
            opcion3[3, 4] = Volcán;
            opcion3[3, 5] = Desierto;
            opcion3[4, 0] = Acuático;
            opcion3[4, 1] = Vegetación;
            opcion3[4, 2] = Vegetación;
            opcion3[4, 3] = Desierto;
            opcion3[4, 4] = Desierto;
            opcion3[4, 5] = Desierto;
            opcion3[5, 0] = Acuático;
            opcion3[5, 1] = Vegetación;
            opcion3[5, 2] = Desierto;
            opcion3[5, 3] = Desierto;
            opcion3[5, 4] = Desierto;
            opcion3[5, 5] = Desierto;
           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
