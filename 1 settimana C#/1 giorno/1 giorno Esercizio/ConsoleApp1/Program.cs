using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esempio creato solamente utilizzando la classe Dipendente
            Dipendente dipendente = new Dipendente();
            dipendente.Cognome = "Pinco";
            dipendente.Nome = "Pallino";
            dipendente.RuoloRicoperto = "Amministratore Delegato";
            dipendente.Stipendio = 1560.52;
            dipendente.DataOraEntrata = DateTime.Now;

            Console.WriteLine(dipendente.ScriviDatiDipendente());
            dipendente.FirmaEntrata();
            dipendente.FirmaUscita();
            

            Atleta atleta1 = new Atleta();
            atleta1.Peso = "85 kg";
            atleta1.Altezza = "175 cm";

            Console.WriteLine(atleta1.ScriviDatiDipendente());
            Console.ReadLine();
        }
    }
}