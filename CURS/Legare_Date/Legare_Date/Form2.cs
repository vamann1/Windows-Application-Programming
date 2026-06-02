using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legare_Date
{
    public partial class Form2 : Form
    {
        BindingSource fbsp;
        public Form2(BindingSource ffbsp)
        {
            InitializeComponent();
            fbsp = ffbsp;
            tbMarca.DataBindings.Add("Text", fbsp, "Marca");
            tbNume.DataBindings.Add("Text", fbsp, "Nume");
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            fbsp.RemoveCurrent();
            fbsp.MoveFirst();
            Close();
        }
    }
}
