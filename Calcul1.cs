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
        /*             -------fonction recursive----------
         * cette fonction recoit une operation sous forme de chaine de caractere contenant un ou plusieurs operateurs et donc plusieurs operandes
         * elle extrait les operateurs
         * s'il y'a moins de 2 operateurs elle appelle la fonction base pour faire l'operation basique
         * sinon elle extrait le premier operateur et les 2 premiers operandes sous forme de chaine
         * effectue le calcul de la premiere operation avec la fonction base
         * recupere le resultat sous forme d'entier qu'elle reconverti en chaine avec la fonction ToString
         * concatene le reste de la chaine initial a ce resultat puis 
         * reappelle cette meme fonction calculatrice avec pour parametre la chaine obtenue
         * le calcul se fera donc de manirer recursive jusqu'a obtenir un calcul basique avec un operateur et 2 operandes
         */

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
            /*Console.WriteLine(operateur);
            Console.WriteLine(operateur.Length);*/

            if (operateur.Length> 2)
            {
                i=0;
                while ((i<chaine.Length) && (chaine[i] != operateur[1]))
                {
                    chaine1 = chaine1 + chaine[i];
                    i++;
                }
                
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
                     
                        Calcul1.calculatrice(machaine);
                    }

                }
            }
            else
            {
                
                int resul=Calcul.baseOperation(chaine);
                Console.WriteLine(resul);
                

            }
        }
    }
}
