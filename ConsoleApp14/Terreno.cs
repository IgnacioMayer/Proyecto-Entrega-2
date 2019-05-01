using System;

namespace ConsoleApp14
{
    public class Terreno
    {
        public string tipo;

        public string GetTerreno()
        {
            if (tipo == "Vegetacn")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                return " ";

            }
            else if (tipo == "Acuatico")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                return " ";
            }
            else if (tipo == "Desierto")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                return " ";
            }
            else if (tipo == "NieveIce")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                return " ";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                return " ";
            }

        }
    }
}
