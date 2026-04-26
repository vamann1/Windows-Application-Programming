using System.Xml;

namespace seminar8
{
    public partial class Form1 : Form
    {
        Carte c;
        Biblioteca biblioteca;
        public Form1()
        {
            InitializeComponent();
            biblioteca = new Biblioteca("ASE");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("carti.xml");
            XmlNodeList xnList = xmlDocument.SelectNodes("/catalog");
            foreach (XmlNode xn in xnList)
            {
                
                XmlNodeList xmlNodeList = xn.ChildNodes;
                foreach (XmlNode node in xmlNodeList)
                {
                    string id = node.Name;
                    string autor = node["author"].InnerText;
                    string titlu = node["title"].InnerText;
                    string domeniu = node["genre"].InnerText;
                    double pret = Convert.ToDouble(node["price"].InnerText);
                    string descriere = node["description"].InnerText;
                    Carte c = new Carte(id, autor, titlu, domeniu, (float)pret, descriere);
                    lbCarti.Items.Add(c.Id + " " + c.Autor + " " + c.Pret);
                    biblioteca.adaugaCarte(c);
                }
            }
            tbTitlu.Text = biblioteca.Nume;
        }

        private void lbCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbCarti.SelectedIndex;
            c = biblioteca.ListaCarti[index];
            TbPlata.Text = (c.Pret * 0.9).ToString();
        }

        private void rbDa_CheckedChanged(object sender, EventArgs e)
        {
            TbPlata.Text = (c.Pret * 0.9).ToString();
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            TbPlata.Text = c.Pret.ToString();
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            string titulatura = cbTitulatura.GetItemText(cbTitulatura.SelectedItem);
            string nume = tbNume.Text;
            string adresa = tbAdresa.Text;
            bool student = rbDa.Checked==true?true:false;
            float plata = float.Parse(TbPlata.Text);

            string mesaj = titulatura + " " + nume + "fiind student" + student + "plateste" + plata;
            mesaj += Environment.NewLine + c.Title + " " + c.Autor;
            MessageBox.Show(mesaj);
        }
    }
}
