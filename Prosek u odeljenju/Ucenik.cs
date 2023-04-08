using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosek_u_odeljenju
{
    public class Ucenik
    {
        private string ime;
        private string prezime;
        private int ocena;

        public Ucenik(string ime, string prezime, int ocena)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Ocena = ocena;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Ocena { get => ocena; set => ocena = value; }

        public override string ToString()
        {
            return ime + " " + prezime + " (" + ocena + ")";
        }
    }
}