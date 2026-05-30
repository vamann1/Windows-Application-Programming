using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_Vaman_Mircea_George
{
    public partial class FormRaioane : Form
    {
        private List<Raion> listaRaioane;
        private Magazin magazinul;
        private Action<string> logAction;

        public FormRaioane(List<Raion> listaRaioane, Magazin magazinul, Action<string> logAction)
        {
            InitializeComponent();
            this.listaRaioane = listaRaioane;
            this.magazinul = magazinul;
            this.logAction = logAction;

            lvRaioane.ContextMenuStrip = cmsLV;
            tvRaioane.ContextMenuStrip = cmsTV;
        }

        private void btnAdaugaRaion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbRaionNume.Text))
                    throw new MagazinValidareException("Numele raionului este invalid!");
                if (string.IsNullOrWhiteSpace(tbRaionCategorie.Text))
                    throw new MagazinValidareException("Categoria este obligatorie!");

                int id = Convert.ToInt32(tbRaionId.Text);
                string nume = tbRaionNume.Text;
                string categorie = tbRaionCategorie.Text;

                Raion r = new Raion(id, nume, categorie);
                listaRaioane.Add(r);
                magazinul = magazinul + r;

                Raion ultimul = magazinul[magazinul.Raioane.Count - 1];
                tbDetaliiRaion.Text = ultimul.Descriere();

                logAction?.Invoke($"Raion adaugat: {r.Nume} [{r.Categorie}]");
                MessageBox.Show($"S-a adaugat raionul '{r.Nume}' in magazinul '{magazinul.Nume}'");
            }
            catch (MagazinValidareException mve)
            {
                MessageBox.Show(mve.Message, "EROARE VALIDARE",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EROARE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbRaionId.Clear();
                tbRaionNume.Clear();
                tbRaionCategorie.Clear();
            }
        }

        private void btnPopuleazaLV_Click(object sender, EventArgs e)
        {
            lvRaioane.Items.Clear();
            foreach (Raion r in listaRaioane)
            {
                ListViewItem item = new ListViewItem(r.Id.ToString());
                item.SubItems.Add(r.Nume);
                item.SubItems.Add(r.Categorie);
                lvRaioane.Items.Add(item);
            }
        }

        private void lvRaioane_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.BackColor = e.Item.Checked ? Color.Red : Color.White;
        }

        private void stergeLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Raion> deSters = new List<Raion>();
            foreach (ListViewItem item in lvRaioane.Items)
            {
                if (!item.Checked) continue;
                int idDeSters = Convert.ToInt32(item.Text);
                foreach (Raion r in listaRaioane)
                    if (r.Id == idDeSters) deSters.Add(r);
            }
            foreach (Raion r in deSters)
            {
                listaRaioane.Remove(r);
                magazinul = magazinul - r;
            }
            for (int i = lvRaioane.Items.Count - 1; i >= 0; i--)
                if (lvRaioane.Items[i].Checked)
                    lvRaioane.Items[i].Remove();
        }

        private void btnStergeLV_Click(object sender, EventArgs e)
        {
            stergeLVToolStripMenuItem_Click(sender, e);
        }

        private void btnPopuleazaTV_Click(object sender, EventArgs e)
        {
            tvRaioane.Nodes.Clear();
            TreeNode parinte = new TreeNode("Raioane");
            tvRaioane.Nodes.Add(parinte);
            foreach (Raion r in listaRaioane)
            {
                TreeNode copil = new TreeNode($"{r.Id}-{r.Nume}-{r.Categorie}");
                copil.Nodes.Add(new TreeNode(r.Produse.Count > 5 ? "Raion mare" : "Raion mic"));
                parinte.Nodes.Add(copil);
            }
            tvRaioane.ExpandAll();
        }

        private void tvRaioane_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int idRaion;
            try { idRaion = Convert.ToInt32(tvRaioane.SelectedNode.Text.Split('-')[0]); }
            catch { idRaion = 0; }

            foreach (Raion r in listaRaioane)
                if (r.Id == idRaion)
                    tbDetaliiRaion.Text = r.Descriere();
        }

        private void stergeTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nod = tvRaioane.SelectedNode;
            if (nod == null) return;
            TreeNode urmator = nod.NextNode ?? nod.PrevNode;
            nod.Remove();
            tvRaioane.SelectedNode = urmator;
        }

        private void btnStergeTV_Click(object sender, EventArgs e)
        {
            stergeTVToolStripMenuItem_Click(sender, e);
        }
    }
}
