using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FKSIT
{
    public class Physical
    {
        public string Fio { get; set; }
        public string SportDiscipline { get; set; } // направление

        public override string ToString()
        {
            return Fio + " " + SportDiscipline;
        }
    }
}
