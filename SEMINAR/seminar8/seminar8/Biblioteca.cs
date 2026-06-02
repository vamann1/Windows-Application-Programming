using System;
using System.Collections.Generic;
using System.Text;

namespace seminar8
{
    internal class Biblioteca
    {
        private string nume;
        private List<Carte> listaCarti;

        public Biblioteca(string nume)
        {
            this.nume = nume;
            this.listaCarti = new List<Carte>();

        }

        public void adaugaCarte(Carte carte)
        {
            listaCarti.Add(carte);
        }

        public string Nume { get => nume; set => nume = value; }
        internal List<Carte> ListaCarti { get => listaCarti; set => listaCarti = value; }
    }
}
