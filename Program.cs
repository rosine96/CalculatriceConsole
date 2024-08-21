namespace Calculette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choix = 1;
            do
            {
                try
                {

                    Console.WriteLine(@"Bienvenue sur notre calculette:
                                veuillez saisir entierement votre operation en utilisant nos operateurs:+,-,*,/
                                 notez bien:ne mettez pas de signe= a la fin de votre operation:");
                    string chaine = Console.ReadLine();



                    Calcul1.calculatrice(chaine);
                }
                catch (Exception)
                {
                    Console.WriteLine("votre operation n'est pas dans le format recommande");
                }
                Console.WriteLine(@"voulez vous effectuer une autre operation?(entrer le chiffre correspondant)
                                       1-oui
                                       2-non");
                choix = int.Parse(Console.ReadLine());
            } while (choix == 1);
                     









        }
    }
}