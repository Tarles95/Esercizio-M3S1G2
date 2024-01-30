using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dipendente
    {
        //l'esempio utilizza solo proprietà ad archiviazione automatica
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Dipartimento { get; set; }
        public double Stipendio { get; set; }
        public string RuoloRicoperto { get; set; }
        public DateTime DataOraEntrata { get; set; }
        public DateTime DataOraUscita
        {
            get
            {
                return DataOraEntrata.AddHours(8);
            }
        }

        public string ScriviDatiDipendente()
        {
            return $"Il dipendente {Cognome} {Nome}, " +
                              $"ricopre il ruolo di {RuoloRicoperto} " +
                              $"ed ha uno stipendio di {Decimal.Parse(Stipendio.ToString())}.";
        }
        public void FirmaEntrata()
        {
            Console.WriteLine($"Il Dipendente {Nome} {Cognome} ha firmato l'entrata alle ore: {DataOraEntrata}");
        }

        public void FirmaUscita()
        {
            Console.WriteLine($"Il Dipendente {Nome} {Cognome} ha firmato l'uscita alle ore: {DataOraUscita}");
        }
    }
}
