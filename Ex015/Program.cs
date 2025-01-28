namespace Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AlexKidd;
            string KiddAlex, jooj;

            Random random = new Random();
            AlexKidd = random.Next(1,4);
            //AlexKidd = 1;

            jooj = "sim";

            while ( jooj!= "não") 
            {

                Console.WriteLine("vai! lá :3");
                KiddAlex = Console.ReadLine();

                if (AlexKidd == 1)
                {
                    Console.WriteLine("joguei Pedra");
                    if (KiddAlex == "pedra" || KiddAlex == "Pedra" || KiddAlex == "predra")
                    {
                        Console.WriteLine("Empatamos!!");
                    }

                    else if (KiddAlex == "tesoura" || KiddAlex == "Tesoura")
                    {
                        Console.WriteLine("Ganhei!!");
                    }
                    else
                    {
                        Console.WriteLine("Perdi! :(");
                    }
                }

                else if (AlexKidd == 2)
                {
                    Console.WriteLine("joguei Papel");
                    if (KiddAlex == "pedra" || KiddAlex == "Pedra")
                    {
                        Console.WriteLine("Ganhei!!");
                    }

                    else if (KiddAlex == "tesoura" || KiddAlex == "Tesoura")
                    {
                        Console.WriteLine("Perdi! :(");
                    }
                    else
                    {
                        Console.WriteLine("Empatamos!!");
                    }
                }

                else
                {
                    Console.WriteLine("Joguei Tesoura! ");
                    if (KiddAlex == "pedra" || KiddAlex == "Pedra")
                    {
                        Console.WriteLine("Perdi! :(");
                    }

                    else if (KiddAlex == "tesoura" || KiddAlex == "Tesoura")
                    {
                        Console.WriteLine("Empatamos!!");
                    }
                    else
                    {
                        Console.WriteLine("Ganhei!!");
                    }

                    

                }
                
            }
        }
    }
}
