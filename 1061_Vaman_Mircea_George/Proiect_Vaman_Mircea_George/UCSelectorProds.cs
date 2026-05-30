using System.Collections.Generic;
using System.Windows.Forms;

namespace Proiect_Vaman_Mircea_George
{
    public partial class UCSelectorProds : UserControl
    {
        public UCSelectorProds()
        {
            InitializeComponent();
        }

        // incarca lista de produse in combobox
        public void IncarcaProduse(List<Produs> produse)
        {
            cbProdus.DataSource = null;
            cbProdus.DataSource = produse;
            cbProdus.DisplayMember = "Nume";
            cbProdus.ValueMember = "Id";
        }

        // returneaza produsul selectat curent
        public Produs SelectedProdus => cbProdus.SelectedItem as Produs;
    }
}
