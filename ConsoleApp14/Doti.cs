using System;
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
