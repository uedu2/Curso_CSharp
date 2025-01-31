namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Eduardo");
            Soma(10,20);
        }

        static void Saudacao(string nome) 
        {

            Console.WriteLine($"olá {nome}, mundo!");
        }

        static void Soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"a soma de {a} + {b} é igual a {resultado}");
        }
    }
}
