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

        private void fereastraNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fc = new Form2();
            fc.Text = "Document_"+i.ToString();
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
            foreach (Form f in MdiChildren)
            {
                f.Close();
                f.Dispose();
            }
        }

        private void scrieDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = @"d:\";
                sfd.Filter = "Fisiere text|*.txt|Toate fisierele|*.*";
                sfd.FilterIndex = 0;
                sfd.FileName = ((Form2)this.ActiveMdiChild).Text + ".txt";
                if(DialogResult.OK == sfd.ShowDialog())
                {
                    File.WriteAllText(sfd.FileName, ((Form2)this.ActiveMdiChild).tb.Text);
                }
            }
        }

        private void citesteDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"d:\";
            ofd.Filter = "Fisiere text|*.txt|Toate fisierele|*.*";
            ofd.FilterIndex = 0;
            if (DialogResult.OK == ofd.ShowDialog())
            {
                Form2 fc = new Form2();
                fc.Text = ofd.FileName;
                fc.MdiParent = this;
                fc.tb.Text = File.ReadAllText(ofd.FileName);
                fc.Show();
            }
        }
    }
}
