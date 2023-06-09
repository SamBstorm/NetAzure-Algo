namespace Exo4_Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*VERSION 1
            double nb1, nb2, resultat;
            string operateur;
            Console.WriteLine("Veuillez introduire le premier nombre :");
            nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez introduire l'opérateur :");
            operateur = Console.ReadLine();
            Console.WriteLine("Veuillez introduire le second nombre :");
            nb2 = double.Parse(Console.ReadLine());
            switch (operateur)
            {
                case "+":
                    resultat = nb1 + nb2;
                    Console.WriteLine($"{nb1} {operateur} {nb2} = {resultat}");
                    break;
                case "-":
                    resultat = nb1 - nb2;
                    Console.WriteLine($"{nb1} {operateur} {nb2} = {resultat}");
                    break;
                case "*":
                    resultat = nb1 * nb2;
                    Console.WriteLine($"{nb1} {operateur} {nb2} = {resultat}");
                    break;
                case "/":
                    if(nb2 != 0)
                    {
                        resultat = nb1 + nb2;
                        Console.WriteLine($"{nb1} {operateur} {nb2} = {resultat}");
                    }
                    else
                    {
                        Console.WriteLine("Calcul impossible");
                    }
                    break;
                default:
                    Console.WriteLine("Calcul impossible");
                    break;

            }*/

            /*VERSION 2*/
            double nb1, nb2, resultat = 0;
            string operateur, message;
            bool estSucces = true;
            Console.WriteLine("Veuillez introduire le premier nombre :");
            nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez introduire l'opérateur :");
            operateur = Console.ReadLine();
            Console.WriteLine("Veuillez introduire le second nombre :");
            nb2 = double.Parse(Console.ReadLine());
            switch (operateur)
            {
                case "+":
                    resultat = nb1 + nb2;
                    break;
                case "-":
                    resultat = nb1 - nb2;
                    break;
                case "*":
                    resultat = nb1 * nb2;
                    break;
                case "/":
                    if (nb2 != 0)
                    {
                        resultat = nb1 / nb2;
                    }
                    else
                    {
                        estSucces = false;
                    }
                    break;
                default:
                    estSucces = false;
                    break;

            }
            if (estSucces) message = $"{nb1} {operateur} {nb2} = {resultat}";
            else message = "Calcul impossible";
            Console.WriteLine(message);
        }
    }
}