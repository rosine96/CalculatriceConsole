﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette
{
    public static class Calcul
    {
        public static int baseOperation(string chaine1)
        {
            string chaine2 = " ";
            int i, j, nb1, nb2, result;
            i = 0;
            result = 0;
            bool trouve = false;
            while (i <= chaine1.Length && trouve == false)
            {
                if ((chaine1[i] == '-') || (chaine1[i] == '+') || (chaine1[i] == '*') || (chaine1[i] == '/'))
                {
                    trouve = true;
                }
                else
                {
                    chaine2 = chaine2 + chaine1[i];
                    i++;
                }

            }
            if (i > chaine1.Length)
            {
                Console.WriteLine("votre operation n'a pas d'operateur ou vous n'avez pas utilise un de nos operateurs");
            }
            else
            {
                nb1 = int.Parse(chaine2);
                chaine2 = " ";
                for (j = i + 1; j < chaine1.Length; j++)
                {
                    chaine2 = chaine2 + chaine1[j];
                }
                nb2 = int.Parse(chaine2);
                switch (chaine1[i])
                {
                    case '-':
                        result = nb1 - nb2;

                        break;
                    case '+':

                        result = nb1 + nb2;
                       

                        break;
                    case '*':

                        result = nb1 * nb2;

                        break;
                    case '/':
                        if (nb2 == 0)
                        {
                            Console.WriteLine("le diviseur doit etre non nul");
                        }
                        else
                        {
                            result = nb1 / nb2;

                        }
                        break;
                    default:
                        Console.WriteLine("veuillez choisir un de nos operateurs");
                        break;



                }

            }
            Console.WriteLine(result);
          
            return result;
        }
    }
}
