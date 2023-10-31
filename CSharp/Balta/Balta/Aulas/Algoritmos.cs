using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.Aulas
{
    internal class Algoritmos
    {
        public void Executar()
        {
            float[] precos = new float[5];
            precos[0] = 100000;
            precos[1] = 46000;
            precos[2] = 16000;
            precos[3] = 46000;
            precos[4] = 17000;

            int maisBarato = 0;

            for(int atual  = 0; atual <= 4; atual++)
            {
                if (precos[atual] < precos[maisBarato])
                {
                    maisBarato = atual;
                }
            }

            Console.WriteLine($"O Carro mais barato custa: {precos[maisBarato]}");
        }
    }
}
