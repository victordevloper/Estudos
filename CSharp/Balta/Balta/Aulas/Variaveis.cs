using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.Aulas
{
    public  class Variaveis
    {
        public static void MostrarVariaveis()
        {
            var texto = "Bem Vindo";
            string nome = "Victor";
            bool pulando = false;
            float altura = 1.69f;
            int idade = 22;
            char sexo = 'M';


            Console.WriteLine($"{texto}, nome: {nome}, idade: {idade}, gênero: {sexo}, altura: {altura}, ele está pulando?: {pulando}");
        }
    }
}
