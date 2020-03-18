//Tema2 Lab3 ----- Ex. 1

using System;

namespace Teema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tema1 PIU Andrei Ventuneac 3121A Calculatoare\n");


            //APELARE CONSTRUCTOR NOU LAB3---------
            Class1 elev1 = new Class1("Ion, Popescu, 9.5");
            Console.WriteLine(elev1.afisare());

            //test primul elev + afisare
            Class1 elev = new Class1("Andrei", "Tudor", 10);
            Console.WriteLine(elev.afisare());

            //sir de obiecte + functie random
            string[] nume = new string[] { "Popescu", "Maradona", "Georgescu", "Scutescu" };
            string[] prenume = new string[] { "Andrei", "Alexandru", "Mircea", "Stefan" };

            Class1[] elevi = new Class1[50];
            Random rnd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                string nume_ = nume[rnd.Next(0, nume.Length)];
                string prenume_ = prenume[rnd.Next(0, prenume.Length)];
                double nota_ = rnd.Next(1, 10);
                elevi[i] = new Class1(nume_, prenume_, nota_);
                elevi[i].setstatus(nota_);
                Console.WriteLine(elevi[i].afisare());
            }

            //afisare elevi respinsi
            int nr = 0;
            Console.WriteLine("\nElevii respinsi:");
            for (int i = 0; i <= 10; i++)
            {
                if (elevi[i].afisareresp() != string.Empty)
                {
                    nr++;
                    Console.WriteLine(elevi[i].afisareresp());
                }
            }

            //reexaminare - raspunde la o intrebare pentru a trece sau ramai picat!
            Console.WriteLine("\nDoriti o reexaminare a elevilor? (DA/NU)");
            string raspuns;
            raspuns = Console.ReadLine();
            string[] intrebare = new string[] { "Ce functie este utilizata pentru a afisa un text pe o line de consola?", "Ce functie este utilizata pentru a citi o linie de pe consola?", "O clasa poate avea membrii publici?" };
            string[] raspunss = new string[] { "Console.WriteLine()", "Console.ReadLine()", "DA" };
            int admis = 0;

            if (raspuns == "DA")
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (elevi[i].getstatus().Equals("respins"))
                    {
                        Console.Write(elevi[i].getnumepr() + " cu intrebarea:  ");
                        string intrebare_ = intrebare[rnd.Next(0, intrebare.Length)];
                        Console.Write(intrebare_ + "\n");
                        string raspuns_ = Console.ReadLine();

                        for (int j = 0; j <= 2; j++)
                        {
                            if (intrebare_.Equals(intrebare[j]))
                            {
                                if (raspuns_.Equals(raspunss[j]))
                                {
                                    admis = 1;
                                }
                                else
                                {
                                    admis = 0;
                                }
                            }
                        }

                        if (admis == 1)
                        {
                            Console.WriteLine("Felicitari sunteti admisi cu nota 5!\n");
                            elevi[i].setnota(5);
                        }
                        else
                        {
                            Console.WriteLine("Ati picat iar testul!");
                        }

                    }
                }
            }

            //reafisare elevi respinsi

            for (int i = 0; i <= 10; i++)
            {
                if (elevi[i].getstatus().Equals("respins"))
                {
                    Console.WriteLine(elevi[i].afisareresp());
                }
            }






        }
    }
}