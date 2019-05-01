using System;
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
        }
    }
}
