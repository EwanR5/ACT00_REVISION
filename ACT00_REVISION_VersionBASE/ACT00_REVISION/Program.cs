using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            string methode;
            string infos;

            MethodesDuProjet Outils = new MethodesDuProjet();
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                // ...
                // ...
                // ...

                // ordonner les côtés => APPEL ORDONNECOTES
                // ...
                Outils.Triangle(c1, c2, c3);
                if (ok = true)
                {
                    methode = "triangle";
                    Outils.Affiche(out infos, ok, methode);
                    Console.WriteLine(infos);
                    Console.ReadLine();

                    Outils.Equi(c1, c2, c3);
                    if (ok = true)
                    {
                        methode = "equilateral";
                        Outils.Affiche(out infos, ok, methode);
                        Console.WriteLine(infos);
                        Console.ReadLine();
                    }
                    else
                    {
                        Outils.TriangleRectangle(c1, c2, c3);
                        if (ok = true)
                        {
                            methode = "rectangle";
                            Outils.Affiche(out infos, ok, methode);
                            Console.WriteLine(infos);
                            Console.ReadLine();
                        }
                        else
                        {
                            methode = "rectangle";
                            Outils.Affiche(out infos, ok, methode);
                            Console.WriteLine(infos);
                            Console.ReadLine();
                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        //...
                        //...
                        //... A vous de voir en combien de lignes...
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
