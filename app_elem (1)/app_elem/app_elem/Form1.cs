using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_elem
{
    public partial class Form1 : Form
    {
        Element element;
        public Form1()
        {
            InitializeComponent();
            element = new Element();
            element.Ev_Mod_Valoare += Obel_Ev_Mod_Valoare;
        }

        private void Obel_Ev_Mod_Valoare(Element obj)
        {
            txtPatrat.Text = obj.Patrat.ToString();
            string s = $" {obj.Valoare,6} | {obj.Patrat,8}|";
            lb.Items.Add(s);
            var rd = lv.Items.Add(obj.Valoare.ToString());
            rd.SubItems.Add(obj.Patrat.ToString());
        }

        private void btnSetValoare_Click(object sender, EventArgs e)
        {
            txtValoare_Validating(txtValoare, new CancelEventArgs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValoare.Text = element.Valoare.ToString();
            txtPatrat.Text = element.Patrat.ToString();
        }

        private void txtValoare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                btnSetValoare_Click(null, null);
                txtValoare.SelectAll();
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lb.SelectedIndex!=-1)
            {
                string sel = lb.SelectedItem as string;
                txtValoare.Text = (sel.Split('|')[0]).Trim();
            }

        }

        private void txtValoare_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                element.Valoare = int.Parse(txtValoare.Text);
                lb.SelectedIndex = -1;
                err.SetError(txtValoare, null);
            }
            catch (FormatException ex)
            {
                err.SetError(txtValoare, "Trebuie numar!!");
                e.Cancel = true;
                //MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Tag.ToString() == "D")
            { lv.View = View.Details; return; }
            if (((RadioButton)sender).Tag.ToString() == "L")
            { lv.View = View.List; return; }
            if (((RadioButton)sender).Tag.ToString() == "T")
            { lv.View = View.Tile; return; }
        }
    }
}
