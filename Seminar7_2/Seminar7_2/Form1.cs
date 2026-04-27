using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar7_2
{

    public partial class Form1 : Form
    {
        List<TextBox> listaTB = new List<TextBox>();
        List<Produs> listaProduse = new List<Produs>();
        public Form1()
        {
            InitializeComponent();
            listaTB.Add(tbDenumire);
            listaTB.Add(tbPret);
            listaTB.Add(tbCantitate);
            listaTB.Add(tbValoareTotala);
            tbCantitate.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
            tbPret.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void tbCifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>='0' && e.KeyChar<'9' || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAdaugaLinie_Click(object sender, EventArgs e)
        {
            int X = listaTB[0].Location.X;
            int Y = listaTB[listaTB.Count-1].Location.Y;
            int distantaTB = listaTB[1].Location.X - listaTB[0].Location.X;
            for(int i=0; i<4; i++)
            {
                TextBox tb = new TextBox();
                tb.Location = new Point(X, Y+40);
                X += distantaTB;
                tb.Width = tbDenumire.Width;

                if(i==1 || i == 2)
                {
                    tb.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
                }
                if (i == 3)
                {
                    tb.ReadOnly= true;
                }
                listaTB.Add(tb);
                this.Controls.Add(tb);
            }
        }

        private void btnCalculeazaTotal_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lvProduse.Items.Clear();
            double valoareTotala = 0;

            for(int i=0; i<listaTB.Count; i += 4)
            {
                if (listaTB[i].Text == "")
                {
                    errorProvider1.SetError(listaTB[i], "Adaugati denumirea!");
                }
                else if (listaTB[i+1].Text == "")
                {
                    errorProvider1.SetError(listaTB[i + 1], "Adaugati pretul!");
                }
                else if (listaTB[i+2].Text == "")
                {
                    errorProvider1.SetError(listaTB[i + 2], "Adaugati cantitatea!");
                }
                else
                {
                    string denumire = listaTB[i].Text;
                    double pret = Convert.ToDouble(listaTB[i + 1].Text);
                    int cantitate = Convert.ToInt32(listaTB[i+2].Text);

                    Produs p = new Produs(denumire, pret, cantitate);
                    listaProduse.Add(p);

                    double valoare = pret * cantitate;
                    valoareTotala += valoare;
                    listaTB[i + 3].Text = valoare.ToString();

                    ListViewItem lvi = new ListViewItem(p.Denumire);
                    lvi.SubItems.Add(p.Pret.ToString());
                    lvi.SubItems.Add(p.Cantitate.ToString());
                    lvi.SubItems.Add(valoareTotala.ToString());
                    lvProduse.Items.Add(lvi);
                }
                tbValoareTotala.Text= valoareTotala.ToString();
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            MessageBox.Show("Comanda a fost efectuata!\n" +"Data: " + data);

            StreamWriter sw = new StreamWriter("comanda.txt");
            sw.WriteLine("Denumire | Pret | Cantitate | Valoare");
            for (int i = 0; i < listaProduse.Count; i++) {
                sw.WriteLine(listaProduse[i].Denumire + " | " + listaProduse[i].Pret.ToString() + " | " + listaProduse[i].Cantitate.ToString() + " | " + (listaProduse[i].Cantitate* listaProduse[i].Pret).ToString());

            }
            sw.WriteLine("Valoarea totala a comenzii: " + tbValoareTotala.Text);
            sw.Close();
        }
    }
}
