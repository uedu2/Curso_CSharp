using System;

namespace Ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wesls;
            Console.WriteLine("Digite um número");
            wesls = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=wesls;i++) 
            {
               
               if (i % 2 == 0) 
               {
                    Console.Write("{0}, ", i);
               }
               
            }
        }
    }
}
