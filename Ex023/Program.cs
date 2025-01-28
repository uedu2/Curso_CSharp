namespace Ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhadigitada;

            

            do
            {
                Console.WriteLine("Digite a senha: ");
                senhadigitada = Console.ReadLine();
            }while (senhadigitada != senha);
        }
    }
}
