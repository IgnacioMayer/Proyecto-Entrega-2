using System;
namespace ConsoleApp14
{
    class Gofue : Bitmon
    {
        public Gofue(int[] posicion) : base(posicion)
        {
            Random random = new Random();
            int vida = random.Next(8, 13);
            this.Tipo = "Gofue";
            this.Posicion = posicion;
            this.TiempoVida = vida;
            this.Multiplicador = 1.1f;
            this.PuntosdeAtaque = 19;
            this.PuntosdeVida = 29;
        }
        public override void Mover(Mapa mapa)
        {
        }
    }
}
