namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA,ladoB,ladoC;

            Console.WriteLine("Digite o valor do Lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do Lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do Lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triângulo.");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("Ele é um Triângulo Equilátero");
                }
                else if ((ladoA == ladoC) || (ladoB == ladoA) || (ladoC == ladoB))
                {
                    Console.WriteLine("Ele é um Triângulo Isósceles.");
                }
                else 
                {
                    Console.WriteLine("Ele é um Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os Valores informados não formam um triângulo.");
            }

         
          
        }
    }
}
