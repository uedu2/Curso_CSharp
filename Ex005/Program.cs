namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,num2;
            Console.WriteLine("digite a primeira nota");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a segunda nota");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a média do Aluno é:{0}.",(num+num2)/2);
        }
    }
}
