namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[,] note = new int[4,15];
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
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    note[i, j] = 0;
                }
            }
        }

        public void SetNote(int[,] _note)
        {
            int nr = 0, k;
           
            for (int i = 0; i < 4; i++)
            {
                k = 0;
                for(int j = 0;j<15;j++)
                {
                    if (_note[i,j] >= MINIM && _note[i,j] <= MAXIM)
                    {
                        note[i,k] = _note[i,k];
                        k++;
                    }
                }
               
            }
        }

   
        public void SetNote(string sirNote)
        {
            int k = 0, i, j = 0,bun;


            string[] _note = sirNote.Split(',');
            string[] note_;
            
            for (i = 0; i < _note.Length; i++)
            {
                k = 0;
                note_ = _note[i].Split(' ');
                foreach (string nota in note_)
                {
                    if ((int.TryParse(nota, out bun)) && bun >= MINIM && bun <= MAXIM)
                    {
                        note[i, k] = bun;
                        k++;
                    }
                }
            }

        }
    

        public string ConversieLaSir()
        {
            int k = 0;
            string sNote ="";
            if(note!=null)
            {
                for (int i = 0; i < 4; i++)
                {
                    sNote = sNote + "Anul " + (i+1) +": ";
                    for (int j = 0; j < 15; j++)
                    {
                        sNote = sNote + System.Convert.ToString(note[i, j])+" ";
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
                    for (int j = 0; j < 15; j++)
                    {
                        if (note[i, j] < MIN && note[i, j]!=0)
                            valSub5++;
                        if (note[i, j] > MIN )
                            valPeste5++;
                    }
                }
            }

        }
    }
    
}
