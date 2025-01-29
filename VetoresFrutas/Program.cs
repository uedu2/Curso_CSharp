namespace VetoresFrutas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] frutas = {"Banana","Baunilha","Algodão Doce","Kiwi","Uva","Pastel Azul","Milho","Chili-Dog","Jaca","Graviola"};
            double[] preco = {98.38,91.3,3.99,4.67,5777.49,698.67,79.65,458.70,9086.24,105.99 };
            for (int i = 0; i < frutas.Length; i++) 
            {
                Console.WriteLine(frutas[i] + " R$" + preco[i]);
            }
            Console.WriteLine();
            Console.WriteLine("o maior preço é " + preco.Max());
            Console.WriteLine("o maior preço é " + preco.Min());
            Console.WriteLine("o maior preço é " + preco.Average());
        }
    }
}
