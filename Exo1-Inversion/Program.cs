namespace Exo1_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}