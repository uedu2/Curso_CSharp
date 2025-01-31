namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void contador(int inicio, int fim, int passo)
        {

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
