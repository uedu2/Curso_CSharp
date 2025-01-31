namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Controle de Terrenos");
            Console.WriteLine("====================");
            Console.WriteLine();

            Console.Write("Digite a Largura do Terreno (M): ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a Comprimento do Terreno (M): ");
            double Comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTerreno(largura, Comprimento);
        }

        static void AreaTerreno(double l, double c)
        {
            double a = l * c;
            Console.WriteLine($"a área do terreno de {l}m x {c}m é de {a:F2}m².");
        }
    }
}
