namespace Demo_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            message = "Hello les .net azure!";
            //message = 42;     //Attention, ne pas sauvegarder un type incompatible
            Console.WriteLine(message);

            const int ANNEE = 2023;
            //ANNEE = 2024;     //Attention, une constante ne peut être modifiée
        }
    }
}