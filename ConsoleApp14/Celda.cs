using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Celda
    {
        public Terreno terreno;
        public List<Bitmon> bitmons;
        public int numero_bitmon;
        public Celda()
        {
            try
            {
                this.numero_bitmon = bitmons.Count;
            }
            catch
            {
                numero_bitmon = 0;
            }
            this.bitmons = new List<Bitmon>();
        }
        public void Show()
        {
            if (!bitmons.Any())
            {
                terreno.GetTerreno();
                Console.WriteLine(" ");
            }
            else
            {
                var empList = bitmons.Where(emp => emp.vivo==true).ToList();
                if (empList.Count == 1)
                {
                }
                else if (empList.Count == 2)
                {
                    if ((bitmons[0].Tipo == "Doti" && bitmons[1].Tipo == "Doti") || (bitmons[1].Tipo == "Doti" && bitmons[1].Tipo == "Ent") || (bitmons[0].Tipo == "Ent" && bitmons[1].Tipo == "Doti") || (bitmons[0].Tipo == "Doti" && bitmons[1].Tipo == "Dorvalo") || (bitmons[0].Tipo == "Dorvalo" && bitmons[1].Tipo == "Doti") || (bitmons[0].Tipo == "Doti" && bitmons[1].Tipo == "Gofue") || (bitmons[0].Tipo == "Gofue" && bitmons[1].Tipo == "Doti") || (bitmons[0].Tipo == "Doti" && bitmons[1].Tipo == "Wetar") || (bitmons[0].Tipo == "Wetar" && bitmons[1].Tipo == "Doti") || (bitmons[0].Tipo == "Doti" && bitmons[1].Tipo == "Taplan") || (bitmons[0].Tipo == "Taplan" && bitmons[1].Tipo == "Doti") || (bitmons[1].Tipo == "Ent" && bitmons[1].Tipo == "Ent") || (bitmons[0].Tipo == "Dorvalo" && bitmons[1].Tipo == "Dorvalo") || (bitmons[0].Tipo == "Dorvalo" && bitmons[1].Tipo == "Gofue") || (bitmons[0].Tipo == "Gofue" && bitmons[1].Tipo == "Dorvalo") || (bitmons[0].Tipo == "Gofue" && bitmons[1].Tipo == "Gofue") || (bitmons[0].Tipo == "Wetar" && bitmons[1].Tipo == "Wetar") || (bitmons[0].Tipo == "Wetar" && bitmons[1].Tipo == "Taplan") || (bitmons[0].Tipo == "Taplan" && bitmons[1].Tipo == "Wetar") || (bitmons[0].Tipo == "Taplan" && bitmons[1].Tipo == "Taplan"))
                    {
                        terreno.GetTerreno();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("+");
                    }
                    else if ((bitmons[0].Tipo == "Ent" && bitmons[1].Tipo == "Dorvalo") || (bitmons[0].Tipo == "Dorvalo" && bitmons[1].Tipo == "Ent") || (bitmons[0].Tipo == "Ent" && bitmons[1].Tipo == "Gofue") || (bitmons[0].Tipo == "Gofue" && bitmons[1].Tipo == "Ent") || (bitmons[0].Tipo == "Ent" && bitmons[1].Tipo == "Wetar") || (bitmons[0].Tipo == "Wetar" && bitmons[1].Tipo == "Ent") || (bitmons[0].Tipo == "Ent" && bitmons[1].Tipo == "Taplan") || (bitmons[0].Tipo == "Taplan" && bitmons[1].Tipo == "Ent") || (bitmons[0].Tipo == "Gofue" && bitmons[1].Tipo == "Wetar") || (bitmons[0].Tipo == "Wetar" && bitmons[1].Tipo == "Gofue") || (bitmons[0].Tipo == "Gofue" && bitmons[1].Tipo == "Taplan") || (bitmons[0].Tipo == "Taplan" && bitmons[1].Tipo == "Gofue") || (bitmons[0].Tipo == "Dorvalo" && bitmons[1].Tipo == "Wetar") || (bitmons[0].Tipo == "Wetar" && bitmons[1].Tipo == "Dorvalo") || (bitmons[0].Tipo == "Dorvalo" && bitmons[1].Tipo == "Taplan") || (bitmons[0].Tipo == "Taplan" && bitmons[1].Tipo == "Dorvalo"))
                    {
                        terreno.GetTerreno();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("+");
                    }
                }
            }
        }
    }
}
