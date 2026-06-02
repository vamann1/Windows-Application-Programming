using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar6Tema
{
    public partial class Form1 : Form
    {
        List<Student> listaStudenti = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            incarcaDate();
            lvStudenti.ContextMenuStrip = contextMenuStrip4;
            tvStudenti.ContextMenuStrip = contextMenuStrip5;
        }

        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("Studenti.txt");
            string linie;
            while((linie = sr.ReadLine()) != null)
            {
                try
                {
                    int matricol = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    float medie = float.Parse(linie.Split(',')[2],
                        CultureInfo.InvariantCulture.NumberFormat);

                    Student s = new Student(matricol, nume, medie);
                    listaStudenti.Add(s);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Datele au fost incarcate!");

        }

        private void btnPreluareLV_Click(object sender, EventArgs e)
        {
            foreach (Student s in listaStudenti)
            {
                ListViewItem item = new ListViewItem(s.matricol.ToString());
                item.SubItems.Add(s.nume);
                item.SubItems.Add(s.medie.ToString());
                if(s.medie > 9)
                {
                    item.SubItems.Add("Excelent");

                }
                else  item.SubItems.Add("Bun");
                lvStudenti.Items.Add(item);
            }
        }

        private void btnStergeElemLV_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvStudenti.Items)
            {
                if (item.Checked)
                    lvStudenti.Items.Remove(item);
            }
        }

        private void contextMenuStrip4_Opening(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvStudenti.Items)
            {
                if (item.Checked)
                {
                    item.Remove();
                }
            }
        }

        private void lvStudenti_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.Red;
            }
        }

        private void btnPopulareTV_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Studenti");
            tvStudenti.Nodes.Add(parinte);

            foreach(Student s in listaStudenti)
            {
                TreeNode nodCopil = new TreeNode(s.matricol + "-" + s.nume + "-" +s.medie);
                parinte.Nodes.Add(nodCopil);
                TreeNode nepot = new TreeNode();
                if (s.medie > 9)
                {
                    nepot.Text="Excelent";

                }
                else nepot.Text="Bun";

            }
        }
    }
}
