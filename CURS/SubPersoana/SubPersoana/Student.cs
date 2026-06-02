using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubPersoana
{
    internal class Student:Persoana
    {
        private const string codMatricol = "A";
        static int nrStudenti = 0;
        string matricol;
        double medie;
        List<string> listaMaterii;

        public Student(string nume, string prenume, int varsta, string matricol, double medie, List<string> listaMaterii):base(nume, prenume, varsta)
        {
            this.matricol = matricol;
            this.medie = medie;
            this.listaMaterii = listaMaterii;
            nrStudenti++;
        }

        public string Matricol { get => matricol; }
        public double Medie { get => medie; }
        public List<string> ListaMaterii { get => listaMaterii; }

        public override string ToString()
        {
            string materii="";
            for(int i=0; i<listaMaterii.Count; i++)
            {
                materii += "\n" + listaMaterii[i];
            }
            return base.ToString() + " Matricol: " + matricol + " Medie: " + medie + "\nMaterii: " + materii;
        }

        public static Student operator +(Student stud, string materie)
        {
            Student studNou;
            if (stud == null)
            {
               studNou = new Student("", "", 0, "", 0.0, new List<string>());
            }
            else
            {
                studNou = stud;
            }
            if (stud.listaMaterii == null)
            {
                stud.listaMaterii= new List<string>();
            }
            studNou.listaMaterii.Add(materie);

            return studNou;
        }

        public string this[int index]
        {
            get
            {
                if(index >=0 && index < this.ListaMaterii.Count())
                {
                    return listaMaterii[index];
                }
                else
                {
                    MessageBox.Show("INdex invalid!");
                    return null;
                }
            }
        }
    }
}
