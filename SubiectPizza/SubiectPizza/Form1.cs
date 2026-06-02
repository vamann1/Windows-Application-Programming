using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SubiectPizza
{
    public enum TipuriBlat
    {
        Subtire, Normal, Pufos, Cheese
    }
  
    public partial class Form1 : Form
    {
        public List<ComandaPizza> listaComenzi = new List<ComandaPizza>();
        public List<Topping> listaToppinguri = new List<Topping>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comandaPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComanda fc = new FormComanda(listaComenzi);
            fc.MdiParent = this;
            fc.Show();
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tvComenzi_Click(object sender, EventArgs e)
        {

            tvComenzi.Nodes.Clear();

            TreeNode root = new TreeNode("");
            TreeNode subtire = new TreeNode(TipuriBlat.Subtire.ToString());
            root.Nodes.Add(subtire);
            TreeNode normal = new TreeNode(TipuriBlat.Normal.ToString());
            root.Nodes.Add(normal);
            TreeNode pufos = new TreeNode(TipuriBlat.Pufos.ToString());
            root.Nodes.Add(pufos);
            TreeNode cheese = new TreeNode(TipuriBlat.Cheese.ToString());
            root.Nodes.Add((cheese));

            foreach(ComandaPizza it in listaComenzi)
            {
                if(it.Blat == "Subtire")
                {
                    TreeNode nod = new TreeNode(it.Nume + " - " + it.Blat + " - " + it.DurataRealizare);
                    subtire.Nodes.Add(nod);
                }
                else if (it.Blat == "Normal")
                {
                    TreeNode nod = new TreeNode(it.Nume + " - " + it.Blat + " - " + it.DurataRealizare);
                    normal.Nodes.Add(nod);
                }
                else if (it.Blat == "Pufos")
                {
                    TreeNode nod = new TreeNode(it.Nume + " - " + it.Blat + " - " + it.DurataRealizare);
                    pufos.Nodes.Add(nod);
                }
                else 
                {
                    TreeNode nod = new TreeNode(it.Nume + " - " + it.Blat + " - " + it.DurataRealizare);
                    cheese.Nodes.Add(nod);
                }
            }

            tvComenzi.Nodes.Add(root);
            tvComenzi.Refresh();
            tvComenzi.Show();
            tvComenzi.ExpandAll();
        }

        private void citireComandaDinXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("comanda.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer ser = new XmlSerializer(typeof(ComandaPizza));
                ComandaPizza aux = (ComandaPizza)ser.Deserialize(fs);
                fs.Close();
                listaComenzi.Add(aux);

                /*FileStream fstemp = new FileStream("comenzi.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer sertemp = new XmlSerializer(typeof(ComandaPizza));
                sertemp.Serialize(fstemp, listaComenzi[0]);
                fstemp.Close();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void citireToppingDinBdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexiune = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Examen;" +
                    "Integrated Security=True;TrustServerCertificate=True;");
                conexiune.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TOPPING;", conexiune);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Topping aux = new Topping(dr[0].ToString(), (double)dr[1], (double)dr[2], (int)dr[3]);
                    listaToppinguri.Add(aux);
                }
                conexiune.Close();

                FormTopping ft = new FormTopping(listaToppinguri);
                ft.MdiParent = this;
                ft.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void tvComenzi_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FormTopping ft = new FormTopping(listaToppinguri);
            ft.ShowDialog();

        }
    }
}
