using System.Collections.Generic;
using System;
using System.Linq;
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
            List<int[]> Espacios_v = new List<int[]>();
            List<int[]> Espacios1 = new List<int[]>();
            List<int[]> Espacios2 = new List<int[]>();
            List<int[]> Espacios_b = new List<int[]>();
            for (int i = 0; i < Bitmons.Count; i++)
            {
                int[] pos = Bitmons[i].Posicion;
                Espacios_b.Add(pos);
                for (int j = i + 1; j < Bitmons.Count; j++)
                {
                    if ((Bitmons[i].Posicion[0] == Bitmons[j].Posicion[0]) && (Bitmons[i].Posicion[1] == Bitmons[j].Posicion[1]))
                    {
                        Espacios2.Add(pos);
                    }
                }
            }
            for (int i = 0; i < Alto; i++)
            {
                for (int j = 0; j < Ancho; j++)
                {
                    int[] pos = {i, j};
                    bool hay_1_bitmon = false;
                    bool hay_2_bitmon = false;
                    foreach (var bitmon in Bitmons)
                    {
                        if (bitmon.Posicion[0] == i && bitmon.Posicion[1] == j)
                        {
                            hay_1_bitmon = true;
                        }
                    }
                    foreach (var espacio in Espacios2)
                    {
                        if (espacio[0] == i && espacio[1] == j)
                        {
                            hay_2_bitmon = true;
                        }
                    }
                    if (hay_1_bitmon && !hay_2_bitmon)
                    {
                        Espacios1.Add(pos);
                    }
                    else if (!hay_1_bitmon)
                    {
                        Espacios_v.Add(pos);
                    }
                }
            }
            Espacios_vacios = Espacios_v;
            Espacios_1 = Espacios1;
            Espacios_2 = Espacios2;
           
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

        public void Relaciones()
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
        
        
        public void Show()
        {
            // Creo una Matriz con las celdas que contengan un terreno y un numero n de bitmons que se encuentren en una posicion
            Celda[,] celdas = new Celda[Alto, Ancho];
            for (int i = 0; i < Alto; i++)
            {
                for (int j = 0; j < Ancho; j++)
                {
                    int[] posicion_actual = { i, j };
                    Celda celda = new Celda();
                    celda.terreno = Terrenos[i, j];
                    var bitmon = Bitmons.Where(emp => emp.Posicion == posicion_actual);
                    foreach (var emp in bitmon)
                    {
                        celda.bitmons.Add(emp);
                    }
                    celdas[i, j] = celda;
                }
            }
            for (int i = 0; i < Alto; i++)
            {
                for (int j = 0; j < Ancho; j++)
                {
                    
                    if (celdas[i,j].bitmons.Any())
                    {
                         if (celdas[i, j].bitmons.Count == 1)
                        {
                            celdas[i, j].bitmons[0].Show();
                        }
                        else if (celdas[i, j].bitmons.Count == 2)
                        {
                            if ((celdas[i, j].bitmons[0].Tipo == "Doti" && celdas[i, j].bitmons[1].Tipo == "Doti") || (celdas[i, j].bitmons[1].Tipo == "Doti" && celdas[i, j].bitmons[1].Tipo == "Ent") || (celdas[i, j].bitmons[0].Tipo == "Ent" && celdas[i, j].bitmons[1].Tipo == "Doti") || (celdas[i, j].bitmons[0].Tipo == "Doti" && celdas[i, j].bitmons[1].Tipo == "Dorvalo") || (celdas[i, j].bitmons[0].Tipo == "Dorvalo" && celdas[i, j].bitmons[1].Tipo == "Doti") || (celdas[i, j].bitmons[0].Tipo == "Doti" && celdas[i, j].bitmons[1].Tipo == "Gofue") || (celdas[i, j].bitmons[0].Tipo == "Gofue" && celdas[i, j].bitmons[1].Tipo == "Doti") || (celdas[i, j].bitmons[0].Tipo == "Doti" && celdas[i, j].bitmons[1].Tipo == "Wetar") || (celdas[i, j].bitmons[0].Tipo == "Wetar" && celdas[i, j].bitmons[1].Tipo == "Doti") || (celdas[i, j].bitmons[0].Tipo == "Doti" && celdas[i, j].bitmons[1].Tipo == "Taplan") || (celdas[i, j].bitmons[0].Tipo == "Taplan" && celdas[i, j].bitmons[1].Tipo == "Doti") || (celdas[i, j].bitmons[1].Tipo == "Ent" && celdas[i, j].bitmons[1].Tipo == "Ent") || (celdas[i, j].bitmons[0].Tipo == "Dorvalo" && celdas[i, j].bitmons[1].Tipo == "Dorvalo") || (celdas[i, j].bitmons[0].Tipo == "Dorvalo" && celdas[i, j].bitmons[1].Tipo == "Gofue") || (celdas[i, j].bitmons[0].Tipo == "Gofue" && celdas[i, j].bitmons[1].Tipo == "Dorvalo") || (celdas[i, j].bitmons[0].Tipo == "Gofue" && celdas[i, j].bitmons[1].Tipo == "Gofue") || (celdas[i, j].bitmons[0].Tipo == "Wetar" && celdas[i, j].bitmons[1].Tipo == "Wetar") || (celdas[i, j].bitmons[0].Tipo == "Wetar" && celdas[i, j].bitmons[1].Tipo == "Taplan") || (celdas[i, j].bitmons[0].Tipo == "Taplan" && celdas[i, j].bitmons[1].Tipo == "Wetar") || (celdas[i, j].bitmons[0].Tipo == "Taplan" && celdas[i, j].bitmons[1].Tipo == "Taplan"))
                            {
                                celdas[i, j].terreno.GetTerreno();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("+"+" ");
                            }
                            else if ((celdas[i, j].bitmons[0].Tipo == "Ent" && celdas[i, j].bitmons[1].Tipo == "Dorvalo") || (celdas[i, j].bitmons[0].Tipo == "Dorvalo" && celdas[i, j].bitmons[1].Tipo == "Ent") || (celdas[i, j].bitmons[0].Tipo == "Ent" && celdas[i, j].bitmons[1].Tipo == "Gofue") || (celdas[i, j].bitmons[0].Tipo == "Gofue" && celdas[i, j].bitmons[1].Tipo == "Ent") || (celdas[i, j].bitmons[0].Tipo == "Ent" && celdas[i, j].bitmons[1].Tipo == "Wetar") || (celdas[i, j].bitmons[0].Tipo == "Wetar" && celdas[i, j].bitmons[1].Tipo == "Ent") || (celdas[i, j].bitmons[0].Tipo == "Ent" && celdas[i, j].bitmons[1].Tipo == "Taplan") || (celdas[i, j].bitmons[0].Tipo == "Taplan" && celdas[i, j].bitmons[1].Tipo == "Ent") || (celdas[i, j].bitmons[0].Tipo == "Gofue" && celdas[i, j].bitmons[1].Tipo == "Wetar") || (celdas[i, j].bitmons[0].Tipo == "Wetar" && celdas[i, j].bitmons[1].Tipo == "Gofue") || (celdas[i, j].bitmons[0].Tipo == "Gofue" && celdas[i, j].bitmons[1].Tipo == "Taplan") || (celdas[i, j].bitmons[0].Tipo == "Taplan" && celdas[i, j].bitmons[1].Tipo == "Gofue") || (celdas[i, j].bitmons[0].Tipo == "Dorvalo" && celdas[i, j].bitmons[1].Tipo == "Wetar") || (celdas[i, j].bitmons[0].Tipo == "Wetar" && celdas[i, j].bitmons[1].Tipo == "Dorvalo") || (celdas[i, j].bitmons[0].Tipo == "Dorvalo" && celdas[i, j].bitmons[1].Tipo == "Taplan") || (celdas[i, j].bitmons[0].Tipo == "Taplan" && celdas[i, j].bitmons[1].Tipo == "Dorvalo"))
                            {
                                celdas[i, j].terreno.GetTerreno();
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("+"+ " ");
                            }
                        }
                    }
                    else
                    {
                        celdas[i, j].terreno.GetTerreno();
                    }
                }
                Console.WriteLine(" ");
            }

        }
    }
}