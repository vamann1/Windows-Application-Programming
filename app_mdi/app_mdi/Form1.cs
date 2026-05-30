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

namespace app_mdi
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
            i = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fereastraNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fc =  new Form2();
            fc.Text = "Document " + i.ToString();
            i++;
            fc.MdiParent = this;
            fc.Show();
        }

        private void orizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void inchideFerestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in MdiChildren)
            {
                f.Close();
                f.Dispose();
            }
        }

        private void scrieDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
            {
                Form2 aux = (Form2)this.ActiveMdiChild;
                File.WriteAllText(aux.Text + ".txt", aux.tb.Text);
            }
        }
    }
}
