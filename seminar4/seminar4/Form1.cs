using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar4
{
    public partial class Form1 : Form
    {

        private List<Student> studenti = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1 form = (Form1)sender->form.text;
            MessageBox.Show($"Se deschide {Text}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string facultate = tbFacultate.Text;
            string[] noteString = tbNote.Text.Split(',');
            int[] noteInt = new int[noteString.Length];
            for(int i=0; i<noteString.Length; i++)
                noteInt[i] = int.Parse(noteString[i]);
            Student s = new Student(nume, facultate, noteInt);
            s.calculeazaMedie();
            MessageBox.Show(s.ToString());
            studenti.Add(s);
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            foreach (Student s in studenti)
            {
                tbStud.Text += s.ToString() + Environment.NewLine;
            }
        }
    }
}
