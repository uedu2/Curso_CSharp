﻿namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota_final = 50;
            string resultado;

            if (nota_final >= 60) 
            {
                resultado = "Aprovado";
            }
            else 
            {
                resultado = "Reprovado";
            }

            Console.WriteLine("o Aluno foi {0}.",resultado);
        }
       
    }
}