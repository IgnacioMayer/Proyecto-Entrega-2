using System;
using System.Collections.Generic;

namespace ConsoleApp14
{
    class Wetar : Bitmon
    {
        public Wetar(int[] posicion) : base(posicion)
        {
            Random random = new Random();
            int vida = random.Next(8, 13);
            this.Tipo = "Wetar";
            this.Posicion = posicion;
            this.TiempoVida = vida;
            this.Multiplicador = 0.7f;
            this.PuntosdeAtaque = 18;
            this.PuntosdeVida = 26;
        }
        public override void Mover(Mapa mapa)
        {
            Random random = new Random();
            int numero = random.Next(-1, 2);
            while (Posicion[0] + numero > mapa.Alto | Posicion[0] + numero < 0)
            {
                numero = random.Next(-1, 2);
            }
            Posicion[0] += numero;
            numero = random.Next(-1, 2);
            while (Posicion[1] + numero > mapa.Alto | Posicion[1] + numero < 0)
            {
                numero = random.Next(-1, 2);
            }
            Posicion[1] += numero;
            mapa.Actualizar_espacios();
        }
    }
}
