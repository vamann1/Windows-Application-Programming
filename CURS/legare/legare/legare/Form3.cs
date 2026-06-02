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
    public partial class Form3 : Form
    {
        BindingSource f3bs;
        public Form3(BindingSource fbs)
        {
            InitializeComponent();
            f3bs = fbs;
            tbm.DataBindings.Add("Text", f3bs, "Marca");
            tbn.DataBindings.Add("Text", f3bs, "Nume");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingContext[f3bs].Position -= 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingContext[f3bs].Position += 1;

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
