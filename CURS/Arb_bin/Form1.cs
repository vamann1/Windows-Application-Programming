using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arb_bin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arb.Nodes.Add("NULL");
        }

        static private void Insert_arb(int k, TreeNode frad)
        {
            if (frad.Text == "NULL") frad.Text = k.ToString();
            else
            {
                if(frad.Nodes.Count == 0)
                {
                    frad.Nodes.Add("NULL"); frad.Nodes.Add("NULL");
                }
                if(k<int.Parse(frad.Text)) Insert_arb(k, frad.Nodes[0]);
                else if (k > int.Parse(frad.Text)) Insert_arb(k, frad.Nodes[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_arb(int.Parse(ck.Text), arb.Nodes[0]);
            arb.ExpandAll();
        }
    }
}
