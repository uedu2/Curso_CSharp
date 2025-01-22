using System.IO.Pipes;

namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, val, pres;

            Console.WriteLine("salário");
            sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor da casa");
            val = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Prestações em anos");
            pres = Convert.ToDouble(Console.ReadLine());

            if (val / (pres * 12) < sal * 0.3)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
