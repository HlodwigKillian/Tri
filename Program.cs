using System;

namespace Tri_nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclarations variables
            int[] nombres = new int[] {1,55,2,4,66,2,81,26,2,5 };
            int longeur = nombres.Length;
            int[] resultat = new int[longeur];
            int compteur = 1;
            #endregion
            #region Affichage
            for (int i = 0; i <= longeur - 1; i++)
            {
                //Console.WriteLine(nombres[i]);
                Tri_croissant(nombres);
                Console.WriteLine(resultat[i]);
            }
            Console.ReadLine();
            #endregion
            #region Méthodes
            void Tri_croissant(int[]sequence)
            {
                while (compteur < longeur)
                {
                    for (int i = 1; i <= longeur - 1; i++)
                    {
                        if (sequence[compteur-1] > sequence[i])
                        {
                            int swap = sequence[i];
                            sequence[i] = sequence[compteur-1];
                            sequence[compteur-1] = swap;
                        }
                        compteur++;    
                    }
                }
                resultat = sequence;
            }
            #endregion
        }
    }
}
