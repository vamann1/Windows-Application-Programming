using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubPersoana
{
    public partial class Form1 : Form
    {
        Collection<Student> colectieStudenti = new Collection<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadaugaStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string prenume = tbPrenume.Text;
                int varsta = Convert.ToInt32(tbVarsta.Text);
                string matricol = tbMatricol.Text;
                double medie = double.Parse(tbMedie.Text, CultureInfo.InvariantCulture.NumberFormat);
                List<string> listaMat = new List<string>(tbMaterii.Text.Split(','));
                Student s = new Student(nume, prenume, varsta, matricol, medie, listaMat);
                colectieStudenti.Add(s);
                MessageBox.Show("Studentul a fost adaugat cu succes!");
                tbNume.Clear();
                tbPrenume.Clear();
                tbVarsta.Clear();
                tbMatricol.Clear();
                tbMedie.Clear();
                tbMaterii.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAfiseazaStudenti_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Studenti");
            tv.Nodes.Add(parinte);
            foreach (Student s in colectieStudenti)
            {
                TreeNode copil = new TreeNode(s.Matricol);
                parinte.Nodes.Add(copil);
                TreeNode nepot = new TreeNode(s.ToString());
                copil.Nodes.Add(nepot);
            }
            tv.ExpandAll();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "studenti.dat";
            sfd.Filter = "All files|*.dat";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Student s in colectieStudenti) {
                    sw.WriteLine(s.Matricol);
                    sw.WriteLine(s.ToString()); 
                }
                sw.Close();
            }
         
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files | *.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string continut = File.ReadAllText(ofd.FileName);
                MessageBox.Show(continut);
            }
        }
    }
}
