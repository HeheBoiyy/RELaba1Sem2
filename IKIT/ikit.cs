using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIT
{
    public class ProgrammerEngineer
    {
        public string FIO { get; set; }

        public string ProgrammingLanguage { get; set; } //ЯП

        public override string ToString()
        {
            return FIO + ". Знает " + ProgrammingLanguage;
        }
    }
}
