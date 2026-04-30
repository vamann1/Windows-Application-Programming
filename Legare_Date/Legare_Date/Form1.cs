using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legare_Date
{
    public partial class Form1 : Form
    {
        Modificare fm;
        public Form1()
        {
            InitializeComponent();
            bsp.Add(new Persoana(100, "Vasile"));
            bsp.Add(new Persoana(200, "Maria"));
            bsp.Add(new Persoana(300, "Marcel"));
            fm = new Modificare(bsp);
            fm.TopMost = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form2 fadd = new Form2(bsp);
            fadd.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!fm.Visible) fm.Show();
        }
    }
}
