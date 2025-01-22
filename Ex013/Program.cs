namespace Ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade == 18)
            {
                Console.WriteLine("Chegou a sua hora!");
            }
            else if (idade != 18) 
            {
             
                if (idade < 18)
                {
                    Console.WriteLine("faltam {0} anos",18 - idade);
                }
                else 
                {
                    Console.WriteLine("você se alistou a {0} anos!", idade-18);
                }
                
            }
        }
    }
}
