using System.Collections.Generic;
using System;
namespace ConsoleApp14
{
    public class Mapa
    {
        public List<Bitmon> Bitmons; // Lista de Bitmons
        public List<Bitmon> Bitmons_muertos; // lista de bitmons muertos
        public int Alto;
        public int Ancho;
        public List<int[]> Espacios_vacios;
        public List<int[]> Espacios_1;
        public List<int[]> Espacios_2;
        public Terreno[,] Terrenos; // Matriz con Terrenos

        public Mapa()
        {
            this.Bitmons_muertos = new List<Bitmon>();
            this.Espacios_vacios = new List<int[]>();
            this.Espacios_1 = new List<int[]>();
            this.Espacios_2 = new List<int[]>();
        }
        public void Actualizar_espacios()
        {
            List<int[]> Espacios = new List<int[]>();
            for (int i = 0; i < Alto; i++)
            {
                for (int j = 0; j < Ancho; j++)
                {
                    int[] pos = { i, j };
                    Espacios_vacios.Add(pos);
                    Espacios.Add(pos);
                }
            }
            for (int i = 0; i < Bitmons.Count; i++)
            {
                for (int j = i + 1; j < Bitmons.Count; j++)
                {
                    if ((Bitmons[i].Posicion[0] == Bitmons[j].Posicion[0]) && (Bitmons[i].Posicion[1] == Bitmons[j].Posicion[1]))
                    {
                        Espacios_2.Add(Bitmons[i].Posicion);   
                    }
                    else
                    {
                        if (Espacios_1.Contains(Bitmons[i].Posicion) == false)
                        {
                            Espacios_1.Add(Bitmons[i].Posicion);
                        }
                    }
                    
                    
                }
            }
        }
        public void CrearBitmon(Bitmon papa, Bitmon mama)
        {
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
            numeroRan = random.Next(0, Espacios_vacios.Count);
            Bitmon bitmon;
            if (padre_ganador == "Dorvalo")
            {
                bitmon = new Dorvalo(Espacios_vacios[numeroRan]);
                Bitmons.Add(bitmon);
            }
            else if (padre_ganador == "Doit")
            {
                bitmon = new Doti(Espacios_vacios[numeroRan]);
                Bitmons.Add(bitmon);
            }
            else if (padre_ganador == "Ent")
            {
                bitmon = new Ent(Espacios_vacios[numeroRan]);
                Bitmons.Add(bitmon);
            }
            else if (padre_ganador == "Gofue")
            {
                bitmon = new Gofue(Espacios_vacios[numeroRan]);
                Bitmons.Add(bitmon);
            }
            else if (padre_ganador == "Taplan")
            {
                bitmon = new Taplan(Espacios_vacios[numeroRan]);
                Bitmons.Add(bitmon);
            }

            else if (padre_ganador == "Wetar")
            {
                bitmon = new Wetar(Espacios_vacios[numeroRan]);
                Bitmons.Add(bitmon);
            }
            Espacios_vacios.RemoveAt(numeroRan);
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
                        if ((Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Taplan"))
                        {
                            CrearBitmon(Bitmons[c], Bitmons[d]);
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
                                Bitmons.Remove(Bitmons[c]);
                                Bitmons_muertos.Add(Bitmons[c]);
                                
                            }

                            else if ((Bitmons[d].PuntosdeVida <= 0) && (Bitmons[c].PuntosdeVida > 0))
                            {
                                Bitmons[c].PuntosdeVida += a;//SEGUN ENUNCIADO SI UN BITMON MATA A OTRO RECUPERA LOS PUNTOS DE VIDA
                                Bitmons[d].Morir();
                                Bitmons.Remove(Bitmons[d]);
                                Bitmons_muertos.Add(Bitmons[d]);
                            }
                            else if ((Bitmons[d].PuntosdeVida <= 0) && (Bitmons[c].PuntosdeVida <= 0))
                            {
                                Bitmons[c].Morir();
                                Bitmons[d].Morir();
                                Bitmons.Remove(Bitmons[c]);
                                Bitmons_muertos.Add(Bitmons[c]);
                                Bitmons.Remove(Bitmons[d]);
                                Bitmons_muertos.Add(Bitmons[d]);
                            }
                        }
                    }
                }
               
            }
            
        }
        public void CrearMapa()
        {
            
            for (int fila = 0; fila < Alto; fila++)
            {
                
                for (int col = 0; col < Ancho; col++)
                {
                    
                    int[] a = { fila, col };
                    if (Espacios_vacios.Contains(a))
                    {
                        Terrenos[fila, col].GetTerreno();
                        Console.WriteLine(" ");
                    }
                    else if (Espacios_1.Contains(a))
                    {
                        Terrenos[fila, col].GetTerreno();
                        for (int i = 0; i < Bitmons.Count; i++)
                        {
                            if (Bitmons[i].Posicion == a)
                            {
                                if (Bitmons[i].Tipo == "Doti")
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("-");
                                }
                                else if (Bitmons[i].Tipo == "Dorvalo")
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("-");
                                }
                                else if (Bitmons[i].Tipo == "Ent")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("-");
                                }
                                else if (Bitmons[i].Tipo == "Gofue")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("-");
                                }
                                else if (Bitmons[i].Tipo == "Taplan")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("-");
                                }
                                else if (Bitmons[i].Tipo == "Wetar")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("-");
                                }
                            }
                        }
                            Console.WriteLine(" ");
                    }
                    else if (Espacios_2.Contains(a))
                    {
                        Terrenos[fila, col].GetTerreno();
                        for (int c = 0; c < Bitmons.Count; c++)
                        {
                            for (int d = c; d < c; d++)
                            {
                                if ((Bitmons[c].Posicion == Bitmons[d].Posicion) && (Bitmons[c].Posicion == a))
                                {
                                    if ((Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Doti" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Doti") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Taplan"))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("+");
                                    }
                                    else if ((Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Ent" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Ent") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Gofue" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Gofue") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Wetar") || (Bitmons[c].Tipo == "Wetar" && Bitmons[d].Tipo == "Dorvalo") || (Bitmons[c].Tipo == "Dorvalo" && Bitmons[d].Tipo == "Taplan") || (Bitmons[c].Tipo == "Taplan" && Bitmons[d].Tipo == "Dorvalo"))//los que pelean
                                    {
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("+");
                                    }
                                }
                            }
                        }
                    }

                }
                Console.WriteLine(" ");
            }
        }
    }
}