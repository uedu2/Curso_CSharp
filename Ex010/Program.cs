namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, aum;

            Console.WriteLine("Salário:");
            sal = Convert.ToDouble(Console.ReadLine());

            if (sal > 2500)
            {
                aum = (sal + (sal * 0.05));
                Console.WriteLine("seu aumento é de: {0}", aum);

            }
            else if (sal > 1250)
            {
                aum = (sal + (sal * 0.1));
                Console.WriteLine("seu aumento é de: {0}", aum);
            }
            else
            {
                aum = (sal + (sal * 0.15));
                Console.WriteLine("seu aumento é de: {0}", aum);
            }
        } 
    }
}
