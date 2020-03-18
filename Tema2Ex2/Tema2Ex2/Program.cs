//Tema2 Ex2 LAB 3 Andrei Ventuneac
//Am ales o varianta destul de greoaie din punct de veder al timpului si memorie de executie
//Caut in funtie de prima litera a cuvantului daca este egala cu un index din tabela ASCII
//In cazul in care se gaseste este adaugat in matrice 
//Daca nu se intoduce textul "GOL"
//Argumentele au fost introduse din proprietati->Debug

using System;

namespace Tema2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] mat = new string[100][];
            for (int i = 0; i <= 99; i++)
            {
                mat[i] = new string[50];
            }

            int linie=0, coloana;

            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {
                // afisarea numarului de argumente
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);
                // afisarea argumentelor liniei de comanda
                for (int i = 65; i <= 90; i++)
                {
                    coloana = 0;
                    foreach (string param in args)
                    { 
                    
                        if (param.ToUpper()[0] == i)
                        {
                            mat[linie][coloana] = param;
                            coloana++;
                        }
                        else
                        {
                            mat[linie][coloana] = "GOL";
                        }

                    }
                    linie++;
                    //Console.WriteLine(param[0]);
                }

                for(int i=0; i<linie; i++)
                {
                    for(int j = 0;j<mat[i].Length;j++)
                    {
                        Console.Write("{0} ", mat[i][j]);
                    }
                    Console.Write("\n");

                }
                //Console.ReadKey();
            }
        }
    }
}
