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

namespace Seminar6
{

    public partial class Form1 : Form
    {
        List <Student> listaStudenti = new List<Student> ();
        public Form1()
        {
            InitializeComponent();
            incarcaDate();
            lv.ContextMenuStrip = contextMenuStrip1;
            tv.ContextMenuStrip = contextMenuStrip2;
        }

        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("Studenti.txt");
            string linie;
              
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    int id = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    float medie = float.Parse(linie.Split(',')[2], CultureInfo.InvariantCulture.NumberFormat);
                    Student s = new Student(id, nume, medie);
                    listaStudenti.Add(s);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Datele au fost incarcate!");
        }

        private void btnPopulareLv_Click(object sender, EventArgs e)
        {
            foreach(Student s in listaStudenti){
                ListViewItem item = new ListViewItem(s.IdStudent.ToString());
                item.SubItems.Add(s.Nume);
                item.SubItems.Add(s.Medie.ToString());
                if(s.Medie>9)
                {
                    item.SubItems.Add("Excelent");
                }else
                {
                    item.SubItems.Add("Bun");
                }
                lv.Items.Add(item);

            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnStergeElement_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv.Items)
            {
                if (item.Checked)
                {
                    item.Remove();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv.Items)
            {
                if (item.Checked)
                {
                    item.Remove();
                }
            }
        }



        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.Red;
            }
        }

        private void btnPopulareTv_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Studenti");
            tv.Nodes.Add(parinte);
            foreach (Student s in listaStudenti) {
                TreeNode copil = new TreeNode(s.IdStudent + "-" + s.Nume + "-" + s.Medie);
                parinte.Nodes.Add(copil);
                TreeNode nepot = new TreeNode();
                if (s.Medie > 9)
                {
                    nepot.Text = "Excelent";
                } else
                {
                    nepot.Text = "Bun";
                }
                copil.Nodes.Add(nepot);
            }
            tv.ExpandAll();
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodSelectat = tv.SelectedNode;
            int id;
            try
            {
                   id = Convert.ToInt32(nodSelectat.Text.Split('-')[0]);

            }
            catch
            {
                id = 0;
            }
            foreach(Student s in listaStudenti)
            {
                if (s.IdStudent == id)
                {
                    tbStudenti.Text += s.ToString() + Environment.NewLine;
                }
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            TreeNode nodSelectat = tv.SelectedNode.NextNode;
            if (nodSelectat.NextNode != null)
            {
                nodSelectat = tv.SelectedNode.NextNode;
            }
            else
            {
                if (nodSelectat.PrevNode != null)
                {
                    nodSelectat = tv.SelectedNode.PrevNode;
                }
            }
            tv.SelectedNode.Remove();
            tv.SelectedNode = nodSelectat;
        }
    }
}
