using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubiectPizza
{

    public partial class FormComanda : Form
    {
        public List<ComandaPizza> listaComenzi;
        public FormComanda(List<ComandaPizza> p_listaComenzi)
        {
            InitializeComponent();
            this.listaComenzi = p_listaComenzi;
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string blat = cbBlat.Text;
                int durata = int.Parse(tbDurata.Text);
                List<Topping> lista = new List<Topping>();
                int count = tbTopping.Text.Split('\n').Count();

                for (int i = 0; i < count; i++)
                {
                    string toppingIntreg = tbTopping.Text.Split('\n')[i];

                    string denumire = toppingIntreg.Split(',')[0];
                    double pret = double.Parse(toppingIntreg.Split(',')[1]);
                    double cantitate = double.Parse(toppingIntreg.Split(',')[2]);
                    int cod = int.Parse(toppingIntreg.Split(',')[3]);

                    Topping aux = new Topping(denumire, pret, cantitate, cod);
                    lista.Add(aux);
                }

                ComandaPizza comanda = new ComandaPizza(nume, blat, durata, lista);
                listaComenzi.Add(comanda);

                tbNume.Clear();
                tbDurata.Clear();
                tbTopping.Clear();
                cbBlat.Refresh();

            }
            catch (Exception ex)
            {
                   MessageBox.Show(ex.Message);
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
