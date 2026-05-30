using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Vaman_Mircea_George
{
    public partial class FormDetaliiVanzare : Form
    {
        internal FormDetaliiVanzare(List<Vanzare> listaVanzari, int pozitieInitiala = 0)
        {
            InitializeComponent();

            BindingSource bs = new BindingSource();
            bs.DataSource = listaVanzari;
            bindingNavigator1.BindingSource = bs;

            tbNumeProdus.DataBindings.Add(new Binding("Text", bs, "NumeProdus", true));
            tbCantitate.DataBindings.Add(new Binding("Text", bs, "Cantitate", true));
            tbPretUnitar.DataBindings.Add(new Binding("Text", bs, "PretUnitar", true));
            tbData.DataBindings.Add(new Binding("Text", bs, "Data", true));
            tbValoareTotala2.DataBindings.Add(new Binding("Text", bs, "ValoareTotala", true, DataSourceUpdateMode.Never, null, "F2"));
            tbTVACalculat.DataBindings.Add(new Binding("Text", bs, "TVACalculat", true, DataSourceUpdateMode.Never, null, "F2"));

            // pozitionare la inregistrarea selectata din DGV
            if (pozitieInitiala >= 0 && pozitieInitiala < listaVanzari.Count)
                bs.Position = pozitieInitiala;
        }
    }
}
