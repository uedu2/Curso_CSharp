﻿namespace Ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma, quant;

            soma = quant = 0;
            for (int i = 0; i < 500; i++) 
            {
                if (i % 3 == 0) 
                {
                    soma += i;
                    quant++;
                }
                
                
            }
            Console.WriteLine("A soma dos {0} valores informados é {1}.", quant, soma);
        }
    }
}
