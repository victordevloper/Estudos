using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Balta.Aulas
{
    public class Listas
    {
        public static void MostrarLista()
        {
            List<string> bandas = new List<string>();

            bandas.Add("Slipknot");
            bandas.Add("Escape the fate");
            bandas.Add("Metallica");
            bandas.Add("Megadeth");
            bandas.Add("Black Sabbath");
            bandas.Add("System of a down");
            bandas.Add("Korn");

            foreach (string band in bandas)
            {
                Console.WriteLine(band);
            }
        }
    }
}
