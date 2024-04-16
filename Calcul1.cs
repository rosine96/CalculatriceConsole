using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Calculette
{
    public static class Calcul1
    {
        public static void calculatrice(string chaine)
        {
            string operateur = " ";
            int i, j, k;
            string chaine1 = " ";
            string chaine2 = " ";
            string machaine=" ";
            for ( i = 0; i < chaine.Length; i++)
            {
                if ((chaine[i] == '-') || (chaine[i] == '+') || (chaine[i] == '*') || (chaine[i] == '/'))
                {
                    operateur = operateur + chaine[i];
                }
            }
            Console.WriteLine(operateur);
            Console.WriteLine(operateur.Length);

            if (operateur.Length> 2)
            {
                i=0;
                Console.WriteLine("hello");
                Console.WriteLine(operateur[1]);
                while ((i<chaine.Length) && (chaine[i] != operateur[1]))
                {
                    chaine1 = chaine1 + chaine[i];
                    i++;
                }
                Console.WriteLine(chaine1);
                Console.WriteLine("why");
                if (i < chaine.Length)
                {
                    j = i+1;
                    while (j < chaine.Length && chaine[j] != operateur[2])
                    {
                        chaine2 = chaine2 + chaine[j];
                        j++;
                    }
                    
                    if (j < chaine.Length )
                    {
                        
                        int resultat = Calcul.baseOperation(chaine1 + chaine[i] + chaine2);
                       
                         machaine = resultat.ToString();
                        
                        for (k=j; k<chaine.Length; k++)
                        {
                            machaine = machaine + chaine[k];
                            
                        }
                        Console.WriteLine($"{machaine}");
                        Calcul1.calculatrice(machaine);
                    }

                }
            }
            else
            {
                Console.WriteLine("JsonElement suis ici");
                Calcul.baseOperation(chaine);
                Console.WriteLine("JsonElement suis ici");

            }
        }
    }
}
