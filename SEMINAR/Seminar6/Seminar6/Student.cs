using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    internal class Student
    {
        private int idStudent;
        private string nume;
        private float medie;

        public Student()
        {
            this.idStudent = 0;
            this.nume = string.Empty;
            this.medie = 0.0F;
        }

        public Student(int idStudent, string nume, float medie)
        {
            this.idStudent = idStudent;
            this.nume = nume;
            this.medie = medie;
        }

        public int IdStudent { get => idStudent; set => idStudent = value; }
        public string Nume { get => nume; set => nume = value; }
        public float Medie { get => medie; set => medie = value; }

        public override string ToString()
        {
            return "Studentul" + this.idStudent + "are numele" + this.nume + "si media: " + this.medie;
        }
    }
}
