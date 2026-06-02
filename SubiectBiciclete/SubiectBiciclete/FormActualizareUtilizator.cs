using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubiectBiciclete
{
    public partial class FormActualizareUtilizator : Form
    {
        BindingSource bs;
        public FormActualizareUtilizator(BindingSource bs)
        {
            InitializeComponent();

            this.bs = bs;

            textBox1.DataBindings.Add("Text", bs, "CodU");

            textBox2.DataBindings.Add("Text", bs, "Nume");

            textBox3.DataBindings.Add("Text", bs, "CodB");

            textBox4.DataBindings.Add("Text", bs, "DurataUtilizare");
           
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(err1.GetError(textBox3)) ||
    !string.IsNullOrEmpty(err1.GetError(textBox4)))
            {
                MessageBox.Show("Corectati erorile inainte de salvare!");
                return;
            }
            bs.EndEdit();
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                err1.SetError(textBox4, "Doar numere acceptate!");
                e.Handled = true;
            }
            else
            {
                err1.Clear();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                err1.SetError(textBox3, "Doar numere acceptate!");
                e.Handled = true;
            }
            else
            {
                err1.SetError(textBox3, "");
            }
        }
    }
}
