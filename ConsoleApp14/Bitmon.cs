using System.Collections.Generic;
namespace ConsoleApp14
{
    public abstract class Bitmon
    {
        public string Tipo;
        public int TiempoVida;
        public int TiempoVivido = 0;
        public float Multiplicador;
        public float PuntosdeVida;
        public int PuntosdeAtaque;
        public int CantidadDereproducciones = 0;
        public bool vivo = true;
        public int[] Posicion;

        public Bitmon(int[] posicion)
        {
            this.Posicion = posicion;
        }
        public abstract void Mover(Mapa mapa);
        public void Morir()
        {
            vivo = false;
        }
        public void Envejecer()
        {
            TiempoVida -= 1;
            TiempoVivido += 1;
            if (TiempoVida <= 0)
            {
                vivo = false;
            }
        }
        virtual public void Show()
        {

        }
    }
}
