namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano,anoA;

            Console.WriteLine("Digite o ano do Seu Nascimento");
            ano=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano Atual");
            anoA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0}",anoA-ano);

            if (anoA - ano > 25)
            {
                Console.WriteLine("sua categoria é MASTER!");
            }
            else if (anoA - ano < 25)
            {
                if (anoA - ano < 25 && anoA - ano > 19)
                {
                    Console.WriteLine("sua categoria é SÊNIOR!");
                }

                if (anoA - ano < 19 && anoA - ano > 14)
                {
                    Console.WriteLine("sua categoria é JUNIOR!");
                }

                if (anoA - ano < 14 && anoA - ano > 9)
                {
                    Console.WriteLine("sua categoria é MIRIM!");
                }

            }
        }
    }
}
