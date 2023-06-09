namespace Exo2_ConversionSeconde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Verion Jour First
            int jours, heures, minutes, secondes, temps;
            Console.WriteLine("Entrer un nombre en seconde :");
            temps = int.Parse(Console.ReadLine());
            jours = temps / 86_400;
            //secondes = temps - (86_400 * jours);
            secondes = temps % 86_400;
            heures = secondes / 3_600;
            secondes = temps % 3_600;
            minutes = secondes / 60;
            secondes = temps % 60;

            Console.WriteLine(temps + " secondes correspondent à " + jours + " jour(s) " + heures + " heure(s) " + minutes + " minute(s) " + secondes + " seconde(s)");
            */

            /** Version secondes First
            Console.WriteLine("Entrer un nombre en seconde :");
            int temps = int.Parse(Console.ReadLine());
            int secondes, minutes, heures, jours;
            minutes = temps / 60;
            secondes = temps % 60;
            heures = minutes / 60;
            minutes = minutes % 60;
            jours = heures / 24;
            heures = heures % 24;

            Console.WriteLine(temps + " secondes correspondent à " + jours + " jour(s) " + heures + " heure(s) " + minutes + " minute(s) " + secondes + " seconde(s)");
            */

            int jours, heures, minutes, secondes;
            Console.WriteLine("Entrer un nombre en seconde :");
            secondes = int.Parse(Console.ReadLine());
            jours = secondes / 86_400;
            heures = (secondes % 86_400) / 3600 ;
            minutes = (secondes % 3600) / 60 ;
            Console.WriteLine($"{secondes} secondes correspondent à {jours} jour(s) {heures} heure(s) {minutes} minute(s) {secondes % 60} seconde(s)");
        }
    }
}