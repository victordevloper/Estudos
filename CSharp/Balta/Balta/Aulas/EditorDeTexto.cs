using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.Aulas
{
    internal class EditorDeTexto
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?: ");
            Console.WriteLine("1 - Criar Arquivo.");
            Console.WriteLine("2 - Abrir arquivo.");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    
                    break;

                case 2:

                    break;

                case 0:
                    System.Environment.Exit(0);
                    break;

                default: Console.WriteLine("Opção não é Válida");
                    break;
            }

        }
    }
}
