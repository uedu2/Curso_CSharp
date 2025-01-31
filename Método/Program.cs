namespace Método
{
    internal class Program
    {
        static void escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('=',tam);
            string textocent =texto.PadLeft(tam -2).PadRight(tam -2);
            Console.WriteLine(linha);
            Console.WriteLine(textocent);
            Console.WriteLine(linha);
        }

        static void Main(string[] args)
        {
            escrever("Eduardo Gomes De Lira");
            Console.WriteLine();
            escrever("Curso C#");
            Console.WriteLine();
            escrever("Olá Mundo");
            Console.WriteLine();
        }

    }
}
