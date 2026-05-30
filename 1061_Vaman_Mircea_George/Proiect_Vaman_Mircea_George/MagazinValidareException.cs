using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vaman_Mircea_George
{
    internal class MagazinValidareException : Exception
    {
        public MagazinValidareException(string message) : base(message) { }
    }
}
