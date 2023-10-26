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
                    CriarArquivo();
                    break;

                case 2:
                    AbrirArquivo();
                    break;

                case 0:
                    System.Environment.Exit(0);
                    break;
                case 3:


                default: Console.WriteLine("Opção não é Válida");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }

        }

        static void CriarArquivo()
        {
            Console.Clear();

            Console.WriteLine("Digite o seu texto abaixo (Esc para sair)");
            Console.WriteLine("________________________________________");

            string text = " ";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);
        }

        static void AbrirArquivo()
        {

        }

        static void SalvarArquivo(string text)
        {
            Console.Clear();

            Console.WriteLine("Digite o diretorio onde deseja salvar");
            Console.WriteLine("________________________________________");

            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine("Arquivo salvo com sucesso");

            Console.ReadKey();
            
        }
    }
}
