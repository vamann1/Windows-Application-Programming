using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlExemplu
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            List<Tara> listaTari = new List<Tara>();
            listaTari.Add(new Tara() { ID = 1, Nume = "Romania" });
            listaTari.Add(new Tara() { ID = 2, Nume = "Germania" });
            listaTari.Add(new Tara() { ID = 3, Nume = "Italia" });

            cbTara.DataSource = listaTari;
            cbTara.ValueMember = "ID";
            cbTara.DisplayMember = "Nume";

        }

        public Tara SelectedTara
        {
            get
            {
                return (Tara)cbTara.SelectedItem;
            }
        }

    }
    public class Tara
    {
        public int ID { get; set; }

        public string Nume { get; set; }


    }
}
