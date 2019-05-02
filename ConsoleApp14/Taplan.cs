using System;
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
            int numero = random.Next(-1, 2);
            while (Posicion[0] + numero > mapa.Alto)
            {
                numero = random.Next(-1, 2);
            }
            Posicion[0] += numero;
            numero = random.Next(-1, 2);
            while (Posicion[1] + numero < 0)
            {
                numero = random.Next(-1, 2);
            }
            Posicion[1] += numero;
            mapa.Actualizar_espacios();
        }
    }
}
