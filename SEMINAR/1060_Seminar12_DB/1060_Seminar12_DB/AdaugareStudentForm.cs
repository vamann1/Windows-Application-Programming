using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1060_Seminar12_DB
{
    public partial class AdaugareStudentForm : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Facultate;" +
            "Integrated Security=True;TrustServerCertificate=True;");

        public AdaugareStudentForm()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Studenti (Id, Nume, Medie) VALUES (@id, @nume, @medie);";
            command.Connection = connection;
            command.Parameters.AddWithValue("@id", Convert.ToInt32(tbId.Text));
            command.Parameters.AddWithValue("@nume", tbNume.Text);
            command.Parameters.AddWithValue("@medie", decimal.Parse(tbMedie.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul a fost inserat!");
            this.Close();
        }
    }
}
