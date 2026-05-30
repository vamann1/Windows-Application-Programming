using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace legare
{
    public partial class Form2 : Form
    {
        BindingSource f2bs;
        public Form2(BindingSource fbs)
        {
            InitializeComponent();
            this.f2bs = fbs;
            tbm.DataBindings.Add("Text", f2bs, "Marca");
            tbn.DataBindings.Add("Text", f2bs, "Nume");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2bs.RemoveCurrent();
            f2bs.MoveFirst();
            f2bs.MoveLast();
            Close();
        }
    }
}
