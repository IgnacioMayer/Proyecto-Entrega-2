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
                return " ";

            }
            else if (tipo == "Acuatico")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                return " ";
            }
            else if (tipo == "Desierto")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                return " ";
            }
            else if (tipo == "NieveIce")
            {
                Console.BackgroundColor = ConsoleColor.White;
                return " ";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                return " ";
            }

        }
    }
}
