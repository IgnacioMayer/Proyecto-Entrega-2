using System.Collections.Generic;

namespace ConsoleApp14
{
    public class Mapa
    {
        Bitmon[,,] Bitmons; // aqui van los bitmons con sus posiciones iniciales
        Terreno[,] Terrenos; // aqui va el mapa inicial con sus terrenos

        string ImprimirMapa()
        {

            for (int fila = 0; fila < 6; fila++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Console.Write(" " + opcion3[fila, col].GetTerreno());
                }
                
            }
        }
       
         for (int fila = 0; fila< 6; fila++)
            {
                for (int col = 0; col< 6; col++)
                {
                    Console.Write(" " + opcion3[fila, col].GetTerreno());
                }
                Console.WriteLine(" ");
            }

    }
}
