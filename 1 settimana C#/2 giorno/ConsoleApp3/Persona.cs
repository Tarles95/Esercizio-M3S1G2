using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Persona
    {
        private String _nome, _cognome;
        private int _eta;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }
        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                _eta = value;
            }
        }
        
        public void GetNome()
        {
            _nome = Console.ReadLine();
        }
        public void GetCognome()
        {
            _cognome = Console.ReadLine();
        }
        public void GetEta()
        {

            _eta = Convert.ToUInt16(Console.ReadLine());
        }
        public void GetDettagli()
        {
            Console.WriteLine($"\n I dettagli della persona sono: \n - Nome: {Nome} \n - Cognome: {Cognome} \n - Età: {Eta} \n");
        }

    }
}
