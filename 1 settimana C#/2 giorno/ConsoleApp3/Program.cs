using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona p = new Persona();
            Console.WriteLine("Inserire il nome della persona: ");
            p.GetNome();
            Console.WriteLine("Inserire il cognome della persona: ");
            p.GetCognome();
            Console.WriteLine("Inserire l'età della persona: ");
            p.GetEta();
            p.GetDettagli();
            
            Console.ReadLine();
        }
    }
}
