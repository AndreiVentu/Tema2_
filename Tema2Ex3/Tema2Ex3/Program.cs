using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tema2 PIU Andrei Ventuneac 3121A");
            Student s = new Student("Ionescu");
            char c;
            int n, nr = 0,nran=1;
            int[,] _note = new int[4,15];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("S: Citire note de la tastatura ca un sir de caractere");
                Console.WriteLine("T: Citire note de la tastatura (cate o nota pe rand)");
                Console.WriteLine("C: Citire note din linia de comanda");
                Console.WriteLine("A: Afiaare note");
                Console.WriteLine("I: Info autor");
                Console.WriteLine("N: Afisare numar note <5 & >5");
                Console.WriteLine("M: MATRICE");
                Console.WriteLine("X: Iesire");

                Console.Write("\nAlege optiunea: ");
                c = Convert.ToChar(Console.ReadLine());
                Console.Write("\n");

                switch (c)
                {
                    case 'S':
                        Console.Write("CITIRE SIR: ");
                        s.refresh();
                        string note = s.Citiretastsir();
                        s.SetNote(note);
                        Console.WriteLine(s.ConversieLaSir());
                        break;

                        case 'T':
                        s.refresh();
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("Introduceti numarul de note pentru anul" + nran + ": ");
                            nran++;
                            n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Citire note: ");
                            for (int j= 0; j < n; j++)
                            {
                               _note[i,j] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                            s.SetNote(_note);
                            Console.WriteLine(s.ConversieLaSir());
                            break;
                        
                        case 'C':
                        s.refresh();
                        string txt = string.Join(" ",args);
                            //Console.WriteLine(txt);
                            s.SetNote(txt);
                            Console.WriteLine(s.ConversieLaSir());
                            break;

                        case 'A':
                            Console.WriteLine(s.ConversieLaSir());
                            break;

                        case 'N':
                            int mic, mare;
                            s.NumarareNote(out mic, out mare);
                            Console.WriteLine("NUMAR NOTE MAI MICI DE 5 sunt :" + mic);
                            Console.WriteLine("NUMAR NOTE MAI MARI DE 5 sunt: " + mare);
                            break;

                        case 'I':
                            Console.WriteLine("ANDREI VENTUNEAC CONSOLEKILLER 3121A CALCULATOARE 2020 TO BE CONTINUED!");
                            break;

                        case 'X':
                            Environment.Exit(1);
                            break;

                        case 'M':
                            int[,] mat = new int[10,15];
                            for(int i =0;i<=5;i++)
                            {
                                for(int j = 0;j<=5;j++)
                                {
                                    mat[i,j] = j;
                                }
                            }

                            for (int i = 0; i <= 5; i++)
                            {
                                for (int j = 0; j <= 5; j++)
                                {
                                    Console.Write(mat[i, j]);
                                }
                                Console.Write("\n");
                            }

                            break;
    
                }

                Console.ReadKey();
            }

        }
    }
}
