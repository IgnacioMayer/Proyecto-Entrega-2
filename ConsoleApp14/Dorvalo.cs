using System;
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
            
        }
    }
}
