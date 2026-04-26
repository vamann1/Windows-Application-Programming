using System;
using System.Collections.Generic;
using System.Text;

namespace seminar8
{
    internal class Carte
    {
        private string id;
        private string autor;
        private string title;
        private string domeniu;
        private float pret;
        private string descriere;

        public Carte(string id, string autor, string title, string domeniu, float pret, string descriere)
        {
            this.id = id;
            this.autor = autor;
            this.title = title;
            this.domeniu = domeniu;
            this.pret = pret;
            this.descriere = descriere;
        }

        public string Id { get => id; set => id = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Title { get => title; set => title = value; }
        public string Domeniu { get => domeniu; set => domeniu = value; }
        public float Pret { get => pret; set => pret = value; }
        public string Descriere { get => descriere; set => descriere = value; }
    }
}
