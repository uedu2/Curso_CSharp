namespace Ex020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gen;

            Console.WriteLine("Digite o gênero ");
            gen = Console.ReadLine().ToUpper();

            while (gen != "F" && gen != "M") 
            {
                Console.WriteLine("Digite o gênero");
                gen = Console.ReadLine();
            }
            Console.WriteLine("bem-vindos e bem-vindas ao curso de programa com o C#!");
        }
    }
}
