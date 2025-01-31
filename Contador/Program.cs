namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            contador(1,10,1);
            contador(10, 0, 2);

            escrever("agora é sua vez de personalizar a contagem!");
            Console.Write("Digite o início: ");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o fim: ");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o passo: ");
            int pass = Convert.ToInt32(Console.ReadLine());
            contador(ini, final, pass);
        }

        static void contador(int inicio, int fim, int passo)
        {
            escrever($"contagem de {inicio} até {fim} de {passo} em {passo}");
            Thread.Sleep(1000);
            if (inicio < fim)
            {
                int cont = inicio;

                while (cont <= fim)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont += passo;
                }
                Console.WriteLine("FIM!");
            }
            else 
            {
                int cont = inicio;

                while (cont >= fim)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont -= passo;
                }
                Console.WriteLine("FIM!");
            }
        }
        static void escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('=', tam);
            string textocent = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(textocent);
            Console.WriteLine(linha);
        }
    }
}
