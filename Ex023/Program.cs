namespace Ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhadigitada;
            int tentativas = 0;
            

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhadigitada = Console.ReadLine();
                tentativas++;
                if (senhadigitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("você ainda tem " + (3 - tentativas) + " tentativa(s)");
                    Console.ReadKey();
                }
                else if (senhadigitada != senha && tentativas == 3)
                {
                    Console.WriteLine("Senha incorreta eu acesso está bloqueado");
                    return;
                }
            } while (senhadigitada != senha);

            Console.Clear ();
            Console.WriteLine("Senha correta! - Tentativas: " + tentativas);
            
           
        }
    }
}
