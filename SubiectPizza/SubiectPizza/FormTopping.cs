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
    public partial class FormTopping : Form
    {
        List<Topping> listaToppinguri;
        public FormTopping(List<Topping> lt)
        {
            InitializeComponent();
            listaToppinguri = lt;

            foreach (Topping iterator in listaToppinguri) {
                ListViewItem lvi = new ListViewItem(iterator.Denumire);
                lvi.SubItems.Add(iterator.Pret.ToString());
                lvi.SubItems.Add(iterator.Cantitate.ToString());
                lvi.SubItems.Add(iterator.Cod.ToString());

                listView1.Items.Add(lvi);
            }

            listView1.Show();
        }

        private void btnSalveazaToppinguri_Click(object sender, EventArgs e)
        {

        }
    }
}
