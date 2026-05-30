using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1060_Seminar12_DB
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Facultate;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Studenti", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvStudenti.DataSource = dataTable;
            connection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AdaugareStudentForm form = new AdaugareStudentForm();
            form.Show();
        }
    }
}
