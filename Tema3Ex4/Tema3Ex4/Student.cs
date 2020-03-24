namespace LibrarieEntitati
{
    /// <summary>
    /// EvidentaStudenti3
    ///Poriectul functioneaza doar daca se citesc notele pe toti cei patru ani!!!!!
    ///In caz contrar avem eroare de compilare
    ///Diferenta dintre acest proiect si EvidentaStudenti2 este faptul ca utilizam un tablou in scare si la fiecaer linie citita trebuie sa stim cate elemente sa punem in tablou pe linia respectiva
    ///Daca se apeleaza optiunea N fara a se citi notele avem eroare pentru ca tabloul nu este initializat
    /// </summary>
    public class Student
    {
        // date membre private
        string nume;
        int[][] note = new int[4][];
        const int MINIM = 1;
        const int MAXIM = 10;
        const int MIN = 5;

        // contructor implicit
        public Student()
        {

        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
        }
        public string Citiretastsir()
        {
            string text;
            text = System.Console.ReadLine();
            return text;
        }

        // reinitializare matrice la aplearea fiecarei citiri
        public void refresh()
        {
            if (note is null)
            {

            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < note[i].Length; j++)
                    {
                        note[i][j] = 0;
                    }
                }
            }
        }

        public void SetNote(int[][] _note)
        {
            int nr = 0, k;

            for (int i = 0; i < 4; i++)
            {
                k = 0;
                note[i] = new int[_note[i].Length];
                for (int j = 0; j < _note[i].Length; j++)
                {
                     
                    if (_note[i][j] >= MINIM && _note[i][j] <= MAXIM)
                    {
                        note[i][j] = _note[i][k];
                        k++;
                    }
                }

            }
        }


        public void SetNote(string sirNote)
        {
            int k = 0, i, j = 0, bun,nr;


            string[] _note = sirNote.Split(',');
            string[] note_;

            for (i = 0; i < _note.Length; i++)
            {
                k = 0;
                nr = 0;
                note_ = _note[i].Split(' ');
                // note[i] = new int[note_.Length];
                foreach (string nota in note_)
                {
                    if ((int.TryParse(nota, out bun)) && bun >= MINIM && bun <= MAXIM)
                    {
                        nr++;
                    }
                }
                
                note[i] = new int[nr];
                foreach (string nota in note_)
                {
                    if ((int.TryParse(nota, out bun)) && bun >= MINIM && bun <= MAXIM)
                    {
                        note[i][k] = bun;
                        k++;
                    }
                }
                
            }
        }


        public string ConversieLaSir()
        {
            int k = 0;
            string sNote = "";
            if (note != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    sNote = sNote + "Anul " + (i + 1) + ": ";
                    for (int j = 0; j < note[i].Length; j++)
                    {
                        sNote = sNote + System.Convert.ToString(note[i][j]) + " ";
                    }
                    sNote = sNote + "\n";
                }
            }
            string s = string.Format("Studentul {0} are notele:.... \n{1}", nume, sNote);

            return s;
        }


        public void NumarareNote(out int valSub5, out int valPeste5)
        {
            valSub5 = valPeste5 = 0;
            if (note is null)
            {
                
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < note[i].Length; j++)
                    {
                        if (note[i][j] < MIN && note[i][j] != 0)
                            valSub5++;
                        if (note[i][j] > MIN)
                            valPeste5++;
                    }
                }
            }

        }
    }

}
