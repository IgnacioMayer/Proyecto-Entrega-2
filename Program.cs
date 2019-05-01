using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    abstract class Bitmon
    {
        public string Tipo;
        public int TiempoVida;
        public int Multiplicador;
        public int PuntosdeVida;
        public int PuntosdeAtaque;
        public int CantidadDereproducciones;
        public List<int> Posicion;

        virtual public void Mover(Mapa mapa)
        {

        }
        public bool Morir()
        {
            return true;
        }
        public void Envejecer()
        {

        }
        virtual public void Relacion()
        {

        }
        virtual public bool Nacer()
        {
            return false;
        }
    }
    class Taplan : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
        public void ModificarTerreno(Mapa mapa)
        {

        }
    }
    class Wetar : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
    }
    class Gofue : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
        public void ModificarTerreno(Mapa mapa)
        {

        }
    }
    class Dorvalo : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
    }
    class Doti : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
    }
    class Ent : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
    }
    public class Terreno
    {
        public string tipo;

        public string GetTerreno()
        {
            if (tipo == "Vegetacn")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                return "Vegetacn";
                
            }
            else if (tipo == "Acuatico")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                return "Acuatico";
            }
            else if (tipo == "Desierto")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                return "Desierto";
            }
            else if (tipo == "NieveIce")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                return "NieveIce";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                return "Volcanic";
            }

        }
    }
    public class Mapa
    {
        List<Bitmon> Bitmons;
        List<Terreno> Terrenos;

    }
    class Program
    {

        static void Main(string[] args)
        {
            Terreno Vegetación = new Terreno();
            Vegetación.tipo = "Vegetacn";
            Terreno Acuático = new Terreno();
            Acuático.tipo = "Acuatico";
            Terreno Desierto = new Terreno();
            Desierto.tipo = "Desierto";
            Terreno Nieve = new Terreno();
            Nieve.tipo = "NieveIce";
            Terreno Volcán = new Terreno();
            Volcán.tipo = "Volcanic";


            Console.WriteLine("-=Bienvenido a Bitmonlandia=-");
            Console.WriteLine("Seleccione configuración inicial.");
            Console.WriteLine("Opción 1:");
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
            for (int fila = 0; fila < 10; fila++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write(" " + opcion1[fila, col].GetTerreno());
                }
                Console.WriteLine(" ");
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
            for (int fila = 0; fila < 7; fila++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(" " + opcion2[fila, col].GetTerreno());
                }
                Console.WriteLine(" ");
            }
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
            opcion3[0, 0] = Acuático;
            opcion3[5, 1] = Vegetación;
            opcion3[5, 2] = Desierto;
            opcion3[5, 3] = Desierto;
            opcion3[5, 4] = Desierto;
            opcion3[5, 5] = Desierto;
            for (int fila = 0; fila < 6; fila++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Console.Write(" " + opcion3[fila, col].GetTerreno());
                }
                Console.WriteLine(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
