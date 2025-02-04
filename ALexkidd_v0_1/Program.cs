namespace ALexkidd_v0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()//função do Menu.
        {
            int Jooj = 0;
            string nome;
            string cor = "Red";


            Console.Write("Primeiramente digite seu nome :3 ");
            nome = Console.ReadLine();

            if (nome == "fernando" || nome == "Fernando")
            {
                Console.Write(" vish se é o");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" {0} ", nome);
                Console.ResetColor();
                Console.Write("já estou até com medo do que pode acontecer...");
                Console.ReadLine();
            }

            if (nome == "guilherme" || nome == "Guilherme" || nome == "Gui" || nome == "gui")
            {
                Console.Write("e ai");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" {0}", nome);
                Console.ResetColor();
                Console.Write("? tudo blz mano? XD");
                Console.ReadLine();
            }

            Console.Clear();
            while (Jooj != 5)
            {
                Console.Clear();
                Console.WriteLine("Okay {0} escolha uma opção", nome);
                Console.WriteLine("1 - Jokenpo");
                Console.WriteLine("2 - Escrever um recado");
                //Console.WriteLine("2 - Tente advinhar número que EU estou pensando");
                //Console.WriteLine("3 - Adivinharei o número que VOCÊ está pensando");
                //Console.WriteLine("4 - Escrever um recado");
                Console.WriteLine("5 - sair");
                Jooj = Convert.ToInt32(Console.ReadLine());
                switch (Jooj)

                {
                    case 1:



                        Jokenpo();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("========");
                        Console.WriteLine("|Recado|");
                        Console.WriteLine("========");

                        Mensagem();
                        break;

                    case 3:

                        Console.WriteLine("em construção :(");
                        Console.ReadKey();
                        break;

                    case 4:

                        Console.WriteLine("em construção :(");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void Jokenpo()//função do Jokenpo
        {


            int AlexKidd, Jooj1 = 0;
            string KiddAlex;



            while (Jooj1 != 2)
            {
                Random random = new Random();
                AlexKidd = random.Next(1, 4);
                Console.Clear();
                Console.WriteLine("=========");
                Console.WriteLine("|Jokenpo|");
                Console.WriteLine("=========");
                Console.WriteLine("bora lá! escolha entre Pedra, Papel ou Tesoura (também pode ser 1,2 ou 3)");
                KiddAlex = Console.ReadLine();

                if (AlexKidd == 1)// o Alex jogou Pedra
                {
                    Console.WriteLine("Joguei Pedra");


                    if (KiddAlex == "Pedra" || KiddAlex == "pedra" || KiddAlex == "1")
                    {
                        Console.WriteLine("IHH! Parece que empatamos! :[");

                    }
                    else if (KiddAlex == "Papel" || KiddAlex == "papel" || KiddAlex == "2")
                    {


                        Console.WriteLine("OH! Eu Perdi :c");


                    }
                    else
                    {
                        Console.WriteLine("OPA! Eu venci!! XD");


                    }

                }


                else if (AlexKidd == 2)// o Alex jogou Papel
                {
                    Console.WriteLine("Joguei Papel");


                    if (KiddAlex == "Pedra" || KiddAlex == "pedra" || KiddAlex == "1")
                    {
                        Console.WriteLine("OPA! Eu venci!! XD");

                    }
                    else if (KiddAlex == "Papel" || KiddAlex == "papel" || KiddAlex == "2")
                    {


                        Console.WriteLine("IHH! Parece que empatamos! :[");


                    }
                    else
                    {
                        Console.WriteLine("OH! Eu Perdi :c");


                    }
                }


                else// o Alex jogou Tesoura
                {
                    Console.WriteLine("Joguei Tesoura");


                    if (KiddAlex == "Pedra" || KiddAlex == "pedra" || KiddAlex == "1")
                    {
                        Console.WriteLine("OH! Eu Perdi :c");

                    }
                    else if (KiddAlex == "Papel" || KiddAlex == "papel" || KiddAlex == "2")
                    {


                        Console.WriteLine("OPA! Eu venci!! XD");


                    }
                    else
                    {
                        Console.WriteLine("IHH! Parece que empatamos! :[");


                    }

                }
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("Quer continuar Jogando? (Digite 2 para voltar ao Menu)");

                Jooj1 = Convert.ToInt32(Console.ReadLine());
            }


        }

        static void Adivinhameu()
        {

        }

        static void advinhaseu()
        {

        }
        static void Mensagem() //Função da Mensagem
        {

            string texto, nomedo;
            Console.WriteLine("Digite o nome do arquivo");
            nomedo = Console.ReadLine();

            string caminho = $@"E:\Curso_C#\ALexkidd_v0_1\{nomedo}.txt";

            Console.WriteLine("Agora escreva a mensagem (mensagens curtas de apenas uma linha)");
            texto = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(caminho))
            {
                sw.WriteLine(texto);
            }

        }


    }
}