using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempproj
{
    public partial class Form1 : Form

    {
        Collection<Student> colectieStudenti = new Collection<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNume.Text == "" || tbPrenume.Text == "" || tbVarsta.Text == "" || tbMaterii.Text == "" || tbMatricol.Text == "" || tbMedie.Text == "")
                    throw new Exception("Datele nu au fost introduse corect!");
                string nume = tbNume.Text;
                string prenume = tbPrenume.Text;
                int varsta = Convert.ToInt32(tbVarsta.Text);
                string matricol = tbMatricol.Text;
                double medie = double.Parse(tbMedie.Text, CultureInfo.InvariantCulture.NumberFormat);
                List<string> materii = new List<string>(tbMaterii.Text.Split(','));
                Student s = new Student(nume, prenume, varsta, matricol, medie, materii);
                colectieStudenti.Add(s);
                MessageBox.Show("Studentul a fost adaugat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbMaterii.Clear();
                tbNume.Clear();
                tbPrenume.Clear();
                tbMatricol.Clear();
                tbMedie.Clear();
                tbVarsta.Clear();
            }
        }

        private void btnAfiseazaStudenti_Click(object sender, EventArgs e)
        {
            tv.Nodes.Clear();
            TreeNode parinte = new TreeNode("Studenti");
            tv.Nodes.Add(parinte);
            foreach(Student s in colectieStudenti)
            {
                TreeNode copil = new TreeNode(s.Matricol);
                parinte.Nodes.Add(copil);
                TreeNode nepot = new TreeNode(s.ToString());
                copil.Nodes.Add(nepot);
            }
            tv.ExpandAll();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("studenti.dat", FileMode.Open, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, colectieStudenti);
            fs.Close();
            MessageBox.Show("Fisierul s-a salvat cu succes!");
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("studenti.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Student> listaStudenti = (List<Student>)bf.Deserialize(fs);
            string afisare = "";
            foreach (Student s in listaStudenti)
            {
                afisare += s.ToString() + "\n\n";
            }

            MessageBox.Show(afisare);
        }
    }
}
