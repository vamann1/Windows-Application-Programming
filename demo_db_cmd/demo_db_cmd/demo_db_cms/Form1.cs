using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_db_cms
{
    public partial class Form1 : Form
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Paw_25; Integrated Security = True; Connect Timeout = 30; Encrypt=False";
        SqlConnection con;
        //DataTable dt;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(cs);
            //dt = new DataTable();
        }

        void Vizualizare_date() 
        {
            string scmd = "select * from persoane";
            con.Open();
            SqlCommand obcmd = new SqlCommand(scmd, con);
            SqlDataReader dr = obcmd.ExecuteReader();
            //dt.Rows.Clear();
            //dt.Load(dr);
            //gv.DataSource = dt;
            while (dr.Read()) 
                gv.Rows.Add(dr[0].ToString(), dr[1].ToString());
            con.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string scmd = "select * from persoane";
            con.Open();
            SqlCommand obcmd = new SqlCommand(scmd, con);
            SqlDataReader dr = obcmd.ExecuteReader();
            gv.ColumnCount = dr.FieldCount;
            gv.Columns[0].Name = dr.GetName(0);
            gv.Columns[1].Name = dr.GetName(1);
            gv.Columns[1].Width = 200;
            con.Close();
            Vizualizare_date();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Text = "Adaugare";
            if (DialogResult.OK == f.ShowDialog()) {

                string ins_cmd = "insert into persoane values(";
                ins_cmd += f.tbm.Text + ",'" + f.tbn.Text + "')";
                con.Open();
                SqlCommand obcmd = new SqlCommand(ins_cmd, con);
                try {
                    int k = obcmd.ExecuteNonQuery();
                    MessageBox.Show("inserat: " + k.ToString() + " tupluri");
                }
                catch (SqlException ex) {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    con.Close();
                    Vizualizare_date();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gv.SelectedRows.Count==0 ){
                MessageBox.Show("Selecteaza un rand");
                return;
            }
            
            var rds = gv.SelectedRows[0];

            string del_cmd = "delete from persoane where marca = @marca";
            con.Open();
            SqlCommand obcmd = new SqlCommand(del_cmd, con);

            obcmd.Parameters.Add("@marca", SqlDbType.Int).Value = int.Parse(rds.Cells[0].Value.ToString());
            try
            {
                int k = obcmd.ExecuteNonQuery();
                MessageBox.Show("Sters: " + k.ToString() + " tupluri");
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                Vizualizare_date();
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            Form2 f = new Form2();
            f.Text = "Modificare";
            f.tbm.Text=gv.SelectedRows[0].Cells[0].Value.ToString();
            f.tbn.Text= gv.SelectedRows[0].Cells[1].Value.ToString();
            f.tbm.ReadOnly = true;
            f.tbn.Select();

            if (DialogResult.OK == f.ShowDialog()) {

                string ins_cmd = "update persoane set nume='" + f.tbn.Text + "' where marca="+f.tbm.Text;
                con.Open();
                SqlCommand obcmd = new SqlCommand(ins_cmd, con);
                try {
                    int k = obcmd.ExecuteNonQuery();
                    MessageBox.Show("Modificat: " + k.ToString() + " tupluri");
                }
                catch (SqlException ex) {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    con.Close();
                    Vizualizare_date();
                }
            }
        }
    }
}
