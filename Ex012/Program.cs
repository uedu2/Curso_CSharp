namespace Ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;

            Console.WriteLine("Digite o Número 1:");
            var1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Número 2:");
            var2 = Convert.ToInt32(Console.ReadLine());

            if (var1 > var2)
            {
                Console.WriteLine("o Valor 1 é maior");
            }
            else if (var1 < var2)
            {
                Console.WriteLine("o Valor 2 é maior");
            }
            else
            {
                Console.WriteLine("nenhum dos dois é maior que o outro");
            }
        }
    }
}
