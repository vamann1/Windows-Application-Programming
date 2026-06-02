using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_db_viz
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paw_25DataSet.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.ds.Persoane);
            dt = new DataTable("tnoua");
            dt.Columns.Add("id",  typeof(int));
            dt.Columns.Add("sir");
            dt.Rows.Add(10, "Inginer");
            ds.Tables.Add(dt);
            gvtm.DataSource = dt;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gv.EndEdit();
            persoaneBindingSource.EndEdit();
            persoaneTableAdapter.Update(this.ds.Persoane);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nt = ds.Tables.Count;
            MessageBox.Show($"Numar tabele {nt}");
        }
    }
}
