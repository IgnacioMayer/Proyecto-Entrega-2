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

        }
    }
}
