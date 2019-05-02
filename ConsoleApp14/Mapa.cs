using System.Collections.Generic;
using System;
namespace ConsoleApp14
{
    public class Mapa
    {
        public List<Bitmon> Bitmons; // Lista de Bitmons 
        public List<Bitmon> Bitmons_muertos; // lista de bitmons muertos
        Terreno[,] Terrenos; // Matriz con Terrenos

        public Mapa()
        {
            this.Bitmons = new List<Bitmon>();
            this.Bitmons_muertos = new List<Bitmon>();
        }

        public void CrearBitmon(Bitmon papa,Bitmon mama)
        {
            int largo = Terrenos.GetLength(0);
            int ancho = Terrenos.GetLength(1);
            float probabilidad = (papa.CantidadDereproducciones * 100) / (papa.CantidadDereproducciones + mama.CantidadDereproducciones);
            Random random = new Random();
            int numeroRan = random.Next(1, 101);
            string padre_ganador;
            if (numeroRan <= probabilidad)
            {
                padre_ganador = papa.Tipo;
            }
            else
            {
                padre_ganador = mama.Tipo;
            }
            foreach (var bitmon in Bitmons) // falta aqui completar el codigo.
            {

            }
            //ergeokrgn
        }

        void CompararPosiciones()
        {
            for (int c = 0; c < Bitmons.Count; c++)
            {
                for (int d = c; d < c; d++)
                {
                    if (Bitmons[c].Posicion == Bitmons[d].Posicion)// si dos bitmons se encuentran en un mismo lugar
                    {
                        //relaciones que se forman entre bitmons.

                        // LOS BITMONS QUE SE REPRODUCEN
                        if (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Doti")
                        {
                            
                        }
                        else if ((Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Doti"))
                        {

                        }
                        else if ((Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Doti"))
                        {

                        }
                        else if ((Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Doti"))
                        {

                        }
                        else if ((Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Doti"))
                        {

                        }
                        else if ((Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Doti"))
                        {

                        }
                        else if (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Ent")
                        {

                        }
                    
                        else if (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Dorvalo")
                        {

                        }
                        else if ((Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Dorvalo"))
                        {

                        }
                        
                        else if ((Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Dorvalo"))
                        {

                        }
                        else if (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Gofue") 
                        {

                        }
                        
                        
                        else if (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Wetar")
                        {

                        }
                        else if ((Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Wetar"))
                        {

                        }
                        else if (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Taplan")
                        {

                        }
                        // LAS PELEAS
                        else if ((Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Dorvalo"))//los que pelean
                        {
                            int a = (int)Bitmons[c].Multiplicador * Bitmons[d].PuntosdeAtaque;
                            int b = (int)Bitmons[c].Multiplicador * Bitmons[d].PuntosdeAtaque;
                            Bitmons[c].PuntosdeVida -= a;
                            Bitmons[d].PuntosdeVida -= b;

                            if ((Bitmons[c].PuntosdeVida <= 0) && (Bitmons[d].PuntosdeVida > 0))
                            {
                                Bitmons[d].PuntosdeVida += b;//SEGUN ENUNCIADO SI UN BITMON MATA A OTRO RECUPERA LOS PUNTOS DE VIDA
                                Bitmons[c].Morir();
                                //FALTA SACARLOS DE LA LISTA
                            }
                            
                            else if ((Bitmons[d].PuntosdeVida <= 0) && (Bitmons[c].PuntosdeVida > 0))
                            {
                                Bitmons[c].PuntosdeVida += a;//SEGUN ENUNCIADO SI UN BITMON MATA A OTRO RECUPERA LOS PUNTOS DE VIDA
                                Bitmons[d].Morir();
                            }
                            else if ((Bitmons[d].PuntosdeVida <= 0) && (Bitmons[c].PuntosdeVida <= 0))
                            {
                                Bitmons[c].Morir();
                                Bitmons[d].Morir();
                            }
                        }
                    }
                }
            }
        }
    }
}
