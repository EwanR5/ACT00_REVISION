using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            
            double c1;
            double c2;
            double c3;
            bool ok = false;
            string methode;
            string infos;

            MethodesDuProjet Outils = new MethodesDuProjet();
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            do
            {
                Console.WriteLine("Quel est la longueur de votre premier coté ?");
                c1 =double.Parse(Console.ReadLine());
                Console.WriteLine("Quel est la longueur de votre second coté ?");
                c2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Quel est la longueur de votre dernier coté ?");
                c3 = double.Parse(Console.ReadLine());
            } while (c1 > 0 && c2 > 0 && c3 > 0);
            do
            {
                Outils.Triangle(ref ok, c1, c2, c3);
                if (ok == true)
                {
                    methode = "triangle";
                    Outils.Affiche(out infos, ok, methode);
                    Console.WriteLine(infos);
                    Console.ReadLine();

                    Outils.Equi(ref ok, c1, c2, c3);
                    if (ok == true)
                    {
                        methode = "equilateral";
                        Outils.Affiche(out infos, ok, methode);
                        Console.WriteLine(infos);
                        Console.ReadLine();
                    }
                    else
                    {
                        Outils.TriangleRectangle(ref ok, c1, c2, c3);
                        if (ok == true)
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
                        Outils.Isocele(ref ok, c1, c2, c3);
                        if (ok == true)
                        {
                            methode = "isocele";
                            Outils.Affiche(out infos, ok, methode);
                            Console.WriteLine(infos);
                            Console.ReadLine();
                        }
                        else
                        {
                            methode = "isocele";
                            Outils.Affiche(out infos, ok, methode);
                            Console.WriteLine(infos);
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    methode = "triangle";
                    Outils.Affiche(out infos, ok, methode);
                    Console.WriteLine(infos);
                    Console.ReadLine();
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
