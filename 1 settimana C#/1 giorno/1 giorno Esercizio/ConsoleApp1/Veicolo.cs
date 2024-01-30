using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Veicolo
    {
        //l'esempio utilizza solo proprietà ad archiviazione automatica
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int CavalliFiscali { get; set; }
        public string Colore { get; set; }
        public DateTime AnnoImmatricolazione { get; set; }
        public TipoAlimentazione TipoAlimentazione { get; set; }
    }

    public enum TipoAlimentazione
    {
        Benzina = 0,
        Diesel = 1,
        Hybrid = 2,
        FullElectric = 3
    }
}