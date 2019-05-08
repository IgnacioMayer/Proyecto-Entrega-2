using System;
using System.Collections.Generic;

namespace ConsoleApp14
{
    class Taplan : Bitmon
    {
        public Taplan(int[] posicion) : base(posicion)
        {
            Random random = new Random();
            int vida = random.Next(11, 16);
            this.Tipo = "Taplan";
            this.Posicion = posicion;
            this.TiempoVida = vida;
            this.Multiplicador = 1.0f;
            this.PuntosdeAtaque = 13;
            this.PuntosdeVida = 32;
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
                    string tipo = mapa.Terrenos[i, j].tipo;
                    if (pos[0] == Posicion[0] + 1 | pos[0] == Posicion[0] | pos[0] == Posicion[0] - 1)
                    {
                        if (pos[1] == Posicion[1] + 1 | pos[1] == Posicion[1] | pos[1] == Posicion[1] - 1)
                        {
                            if (tipo != "Acuatico")
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
                                    if (tipo == "Vegetacn")
                                    {
                                        lista.Add(pos);
                                        lista.Add(pos);
                                    }
                                    else
                                    {
                                        lista.Add(pos);
                                    }
                                }
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
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-");
        }
    }
}
