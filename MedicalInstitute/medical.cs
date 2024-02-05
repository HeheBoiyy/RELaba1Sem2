using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInstitute
{
    public class Medical
    {
        public string Name { get; set; }
        public string Specialization { get; set; } // Специализация 

        public override string ToString()
        {
            return Name + " " + Specialization;
        }
    }
}
