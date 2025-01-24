namespace Ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, opcao = 0;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            while (opcao != 5) 
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - é somar");
                Console.WriteLine("2 - é somar");
                Console.WriteLine("3 - é multiplicar");
                Console.WriteLine("4 - é novos números");
                Console.WriteLine("5 - é Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao) 
                {
                    case 1:
                        n3 = n1 + n2;
                        Console.WriteLine("A soma de {0} + {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 2:
                        n3 = n1 - n2;
                        Console.WriteLine("A subtração de {0} - {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 3:
                        n3 = n1 * n2;
                        Console.WriteLine("A multiplição de {0} X {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o seundo número: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("saindo");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
            }
        }
    }
}
