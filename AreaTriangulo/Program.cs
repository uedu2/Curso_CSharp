namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================");
            Console.WriteLine("Área do Triângulo");
            Console.WriteLine("=================");
            Console.WriteLine();

            Console.Write("Digite a altura: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.Write("Digite a base: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            areatriangulo(altura, Base);

        }
        static void areatriangulo(int h, int b)
        {
            int a = (h * b) / 2;
            Console.WriteLine($"a área do triângulo de altura {h} e base {b} é igual a: {a}");
        }
    }
}
