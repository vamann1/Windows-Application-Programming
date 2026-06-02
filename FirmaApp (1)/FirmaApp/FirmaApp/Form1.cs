using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaApp
{
    public partial class Form1 : Form
    {
        Firma obf;
        public Form1()
        {
            InitializeComponent();
            obf = new Firma("ASE_SRL");
            obf.Ev_Modificare_Firma += Obf_Ev_Modificare_Firma;
        }

        private void Obf_Ev_Modificare_Firma(object sender, Firma_EvArgs e)
        {
            Firma aux = sender as Firma;
            gv.Rows.Clear();
            foreach (Salariat s in aux.Salariati)
                gv.Rows.Add(s.Marca.ToString(), s.Nume, s.Nr_ore.ToString(), s.Salo.ToString());
            if (aux.Nunar_salariati > 0) gv.Rows[e.Index_Salariat].Selected = true;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Esti sigur ?", "DaNu", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_actualizare fa = new Form_actualizare();
            fa.Text = "Adaugare Salariat";
            fa.button1.Text = "Adauga";
            if(DialogResult.OK== fa.ShowDialog())
            {
                Salariat temp = new Salariat
                {
                    Marca = int.Parse(fa.tb_m.Text),
                    Nume = fa.tb_np.Text,
                    Nr_ore = int.Parse(fa.tb_no.Text),
                    Salo = int.Parse(fa.tb_so.Text)
                };
                obf.Adauga_Sal(temp);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += obf.Nume_firma;
        }
    }
}
