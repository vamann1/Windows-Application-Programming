using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vaman_Mircea_George
{
    public interface IFacturabil
    {
        double CalculeazaTVA();
        double ValoareFinala();
    }
}
