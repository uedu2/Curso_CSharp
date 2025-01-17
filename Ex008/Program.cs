namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string resultado;

            Console.WriteLine("Digite um número");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("é par");

            }
            else 
            {
                Console.WriteLine("é impar");
            }

           
        
        }
    }
}
