using System;
using System.Collections.Generic;

namespace ConsoleApp14
{
    class Doti : Bitmon
    {
        public Doti(int[] posicion) : base(posicion)
        {
            Random random = new Random();
            int vida = random.Next(12, 15);
            this.Tipo = "Doti";
            this.Posicion = posicion;
            this.TiempoVida = vida;
            this.Multiplicador = 0.9f;
            this.PuntosdeAtaque = 11;
            this.PuntosdeVida = 36;
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
                                    lista.Add(pos);
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
    }
}
