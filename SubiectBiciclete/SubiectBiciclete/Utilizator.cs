using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectBiciclete
{
    [Serializable]
    public class Utilizator
    {
        private static int contor;
        private readonly int codU;
        private string nume;
        private int codB;
        private int durataUtilizare;

        public Utilizator()
        {
        }

        public Utilizator(string nume, int codB, int durataUtilizare)
        {
            this.codU = ++contor;
            this.nume = nume;
            this.codB = codB;
            this.durataUtilizare = durataUtilizare;
        }

        public int CodU => codU;

        public string Nume { get => nume; set => nume = value; }
        public int CodB { get => codB; set => codB = value; }
        public int DurataUtilizare { get => durataUtilizare; set => durataUtilizare = value; }

        public override string ToString()
        {
            return this.nume;
        }
    }
}
