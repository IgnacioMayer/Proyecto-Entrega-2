using System.Collections.Generic;

namespace ConsoleApp14
{
    abstract class Bitmon
    {
        public string Tipo;
        public int TiempoVida;
        public int Multiplicador;
        public int PuntosdeVida;
        public int PuntosdeAtaque;
        public int CantidadDereproducciones;
        public List<int> Posicion;

        virtual public void Mover(Mapa mapa)
        {

        }
        public bool Morir()
        {
            return true;
        }
        public void Envejecer()
        {

        }
        virtual public void Relacion()
        {

        }
        virtual public bool Nacer()
        {
            return false;
        }
    }
}
