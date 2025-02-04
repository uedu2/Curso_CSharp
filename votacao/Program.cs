namespace votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Em qual ano você nasceu?");
            int nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(voto(nasc));

        }

        static string voto(int ano)
        {
            DateTime dataatual = DateTime.Now;
            int anoatual = dataatual.Year;
            int idade = anoatual - ano;
            if (idade < 16)
            {
                return $"Com {idade} anos: você não vota.";
            }
            else if (idade >= 18 && idade < 70)
            {
                return $"Com {idade} anos: você vota";
            }
            else 
            {
                return $"Com {idade} anos: seu voto é opcional";
            }
            /* int mes = dataatual.Month;
            int dia = dataatual.Day;
            int hora = dataatual.Hour;
            int minuto = dataatual.Minute;
            int segundo = dataatual.Second;*/
        }
    }
}
