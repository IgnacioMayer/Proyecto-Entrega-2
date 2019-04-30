using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
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
    class Taplan:Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
        public void ModificarTerreno(Mapa mapa)
        {

        }
    }
    class Wetar:Bitmon 
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
    }
    class Gofue : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
        public void ModificarTerreno(Mapa mapa)
        {

        }
    }
    class Dorvalo:Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
    }
    class Doti : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
    }
    class Ent : Bitmon
    {
        public override void Mover(Mapa mapa)
        {
            base.Mover(mapa);
        }
        public override void Relacion()
        {
            base.Relacion();
        }
        public override bool Nacer()
        {
            return base.Nacer();
        }
    }
    public class Terreno
    {
        private string tipo;
        
        public string GetTerreno()
        {
            return tipo;
        }
    }
    public class Mapa
    {
        List<Bitmon> Bitmons;
        List<Terreno> Terrenos;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("Hellow Word.")
        }
    }
}
