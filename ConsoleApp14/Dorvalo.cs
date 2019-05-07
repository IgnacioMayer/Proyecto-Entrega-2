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
            Random random = new Random();
            int numero = random.Next(-2, 3);
            while (Posicion[0] + numero > mapa.Alto - 1 | Posicion[0] + numero < 0)
            {
                numero = random.Next(-1, 2);
            }
            Posicion[0] += numero;
            numero = random.Next(-1, 2);
            while (Posicion[1] + numero > mapa.Alto - 1 | Posicion[1] + numero < 0)
            {
                numero = random.Next(-1, 2);
            }
            Posicion[1] += numero;
            mapa.Actualizar_espacios();
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-");
        }
    }
}
