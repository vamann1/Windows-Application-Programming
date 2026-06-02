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
    public partial class Form1 : Form
    {
        Form3 fmd;
        public Form1()
        {
            InitializeComponent();
            bs.Add(new Persoana { Marca = 100, Nume = "Vasile" });
            bs.Add(new Persoana { Marca = 150, Nume = "Ionescu" });
            bs.Add(new Persoana { Marca = 200, Nume = "Gheorghe" });
            fmd = new Form3(bs);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           fmd.TopMost = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form2 fadd = new Form2(bs);
            fadd.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(!fmd.Visible)
                fmd.Show();
        }
    }
}
