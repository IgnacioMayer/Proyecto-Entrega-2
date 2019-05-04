using System;

namespace ConsoleApp14
{
    public class Terreno
    {
        public string tipo;

        public Terreno(string tipo)
        {
            this.tipo = tipo;
        }
        public void GetTerreno()
        {
            if (tipo == "Vegetacn")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            else if (tipo == "Acuatico")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else if (tipo == "Desierto")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            else if (tipo == "NieveIce")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
        }
    }
}
