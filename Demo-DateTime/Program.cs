namespace Demo_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime maintenant = DateTime.Now;
            Console.WriteLine(maintenant);
            DateTime dateNaissance = new DateTime(1987, 9, 27);
            Console.WriteLine(dateNaissance);
            Console.WriteLine($"En millisecondes, il y a { (maintenant - dateNaissance).TotalMilliseconds } ms de différence...");
        }
    }
}