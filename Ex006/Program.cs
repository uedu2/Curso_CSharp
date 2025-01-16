namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media, n1, n2;

            Console.Write("Digite um número:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um número:");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("A média é: {0}", media);
        }
    }
}
