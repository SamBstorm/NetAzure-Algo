namespace Exo5_CalculatriceV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nbN, resultat;
            string operateur, message;
            bool estValid = true;

            Console.WriteLine("Veuillez introduire le premier nombre : ");
            resultat = double.Parse(Console.ReadLine());
            message = $"{resultat}";
            //message = resultat.ToString();
            do
            {
                Console.WriteLine("Veuillez introduire l'opérateur : ");
                operateur = Console.ReadLine();
                if (operateur != "=")
                {
                    Console.WriteLine("Veuillez introduire un nouveau nombre : ");
                    nbN = double.Parse(Console.ReadLine());
                    switch (operateur)
                    {
                        case "+":
                            resultat = resultat + nbN;
                            break;
                        case "-":
                            resultat = resultat - nbN;
                            break;
                        case "*":
                            resultat = resultat * nbN;
                            break;
                        case "/":
                            if (nbN != 0)
                            {
                                resultat = resultat / nbN;
                            }
                            else
                            {
                                estValid = false;
                            }
                            break;
                        default:
                            estValid = false;
                            break;

                    }
                    if (estValid) message = $"{message} {operateur} {nbN}"; 
                }
            } while (operateur != "=" && estValid == true);
            if (estValid)
                Console.WriteLine($"{message} = {resultat}");
            else Console.WriteLine("Calcul impossible");
        }
    }
}