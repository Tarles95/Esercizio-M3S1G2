using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Alteta
    {
        //l'esempio utilizza solo proprietà ad archiviazione automatica
        public string Nominativo { get; set; }
        public string SocietaAppartenenza { get; set; }
        public string NominativoProcuratore { get; set; }
        public double Altezza { get; set; }

        public double Peso { get; set; }

        public DateTime DataNascita { get; set; }
        public int NrCartelloGara { get; set; }
    }
}