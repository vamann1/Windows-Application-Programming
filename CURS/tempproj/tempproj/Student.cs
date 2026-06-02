using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempproj
{
    internal class Student:Persoana
    {
        const string codMatricol ="A";
        static int nrStudenti = 0;
        string matricol;
        double medie;
        List<string> materii;

        public Student(string nume, string prenume, int varsta, string matricol, double medie, List<string> materii):base(nume, prenume, varsta)
        {
            this.matricol = matricol;
            this.medie = medie;
            this.materii = materii;
            nrStudenti++;
        }

        public string Matricol { get => matricol;  }
        public double Medie { get => medie;  }
        public List<string> Materii { get => materii; }

        public override string ToString()
        {
            string materii = "";
            for(int i=0; i<this.materii.Count; i++)
            {
                materii += " " + this.materii[i].ToString();
            }
            return base.ToString() + " Matricol: " + matricol + " Medie: " + medie + " Materii: " + materii;
        }

        public static Student operator +(Student s, string materie)
        {
            s.materii.Add(materie);
            return s;
        }
        
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < this.materii.Count)
                    return this.ToString();
                return null;
            }
        }
    }
}
