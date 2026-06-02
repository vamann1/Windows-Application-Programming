using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SubiectPoligon
{
    public partial class FormAdaugare : Form
    {
        public Poligon PoligonNou { get; private set; }

        public FormAdaugare()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            err1.Clear();

            try
            {
                List<Point> puncte = new List<Point>();
                string[] nr = tbPuncte.Text.Split(',');
                if (nr.Length < 4 || nr.Length % 2 != 0)
                    throw new Exception("Introduceți cel puțin 2 puncte în format x1,y1,x2,y2,...");
                for (int i = 0; i < nr.Length; i += 2)
                {
                    int X = int.Parse(nr[i].Trim());
                    int Y = int.Parse(nr[i + 1].Trim());
                    if (X < 0 || Y < 0)
                    {
                        err1.SetError(tbPuncte, "Coordonatele pot fi doar numere pozitive!");
                        return;
                    }
                    puncte.Add(new Point(X, Y));
                }

                if (string.IsNullOrWhiteSpace(tbCuloare.Text))
                    throw new Exception("Introduceți o culoare!");

                int grosime = int.Parse(tbLinie.Text);

                if (string.IsNullOrWhiteSpace(tbEticheta.Text))
                    throw new Exception("Introduceți o etichetă!");

                PoligonNou = new Poligon(puncte, tbCuloare.Text, grosime, tbEticheta.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPuncte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                err1.SetError(tbPuncte, "Coordonatele pot fi doar nr. pozitive");
            }
        }
    }
}
