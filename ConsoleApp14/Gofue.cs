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
