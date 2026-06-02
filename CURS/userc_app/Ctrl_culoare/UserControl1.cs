using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctrl_culoare
{
    public partial class Uc_culoare: UserControl
    {
        public event Action Ev_Schimbare_culoare;
        byte vcul;
        public Uc_culoare()
        {
            InitializeComponent();
        }

        private void Uc_culoare_Load(object sender, EventArgs e)
        {
            tbc.Text = trbc.Value.ToString();
            vcul = (byte)trbc.Value;
        }

        private void trbc_Scroll(object sender, EventArgs e)
        {
            if(vcul != (byte)trbc.Value)
            {
                tbc.Text = trbc.Value.ToString();
                vcul = (byte)trbc.Value;
                Ev_Schimbare_culoare?.Invoke();
            }
            
        }

        public byte CCuloare => vcul;
    }
}
