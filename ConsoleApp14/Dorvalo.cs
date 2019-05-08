using System;
using System.Collections.Generic;
namespace ConsoleApp14
{
    class Dorvalo : Bitmon
    {
        public Dorvalo(int[] posicion) : base(posicion)
        {
            Random random = new Random();
            int vida = random.Next(10, 14);
            this.Tipo = "Dorvalo";
            this.Posicion = posicion;
            this.TiempoVida = vida;
            this.Multiplicador = 1.2f;
            this.PuntosdeAtaque = 16;
            this.PuntosdeVida = 34;
        }
        public override void Mover(Mapa mapa)
        {
            Random random = new Random();
            List<int[]> lista = new List<int[]>();
            for (int i = 0; i < mapa.Alto; i++)
            {
                for (int j = 0; j < mapa.Ancho; j++)
                {
                    int[] pos = { i, j };
                    if (pos[0] == Posicion[0] + 2 | pos[0] == Posicion[0] + 1 | pos[0] == Posicion[0] | pos[0] == Posicion[0] - 1 | pos[0] == Posicion[0] - 2)
                    {
                        if (pos[1] == Posicion[1] + 2 | pos[1] == Posicion[1] + 1 | pos[1] == Posicion[1] | pos[1] == Posicion[1] - 1 | pos[1] == Posicion[1] - 2)
                        {
                            bool hay_dos = false;
                            foreach (var espacio in mapa.Espacios_2)
                            {
                                if (espacio[0] == pos[0] && espacio[1] == pos[1])
                                {
                                    hay_dos = true;
                                }
                            }
                            if (!hay_dos)
                            {
                                lista.Add(pos);
                            }   
                        }
                    }
                }
            }
            if (lista.Count != 0)
            {
                int numero = random.Next(0, lista.Count);
                Posicion = lista[numero];
                mapa.Actualizar_espacios();
            }
        }
    }
}
