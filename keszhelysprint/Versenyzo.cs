using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keszhelysprint
{
    internal class Versenyzo
    {
        public string Nev { get; set; }

        public int Születési_év { get; set; }

        public int Rajtszám { get; set; }

        public string Neme { get; set; }

        public string Életkor { get; set; }

        public string idö1 { get; set; }

        public string idö2 { get; set; }

        public string idö3 { get; set; }

        public string idö4 { get; set; }

        public string idö5 { get; set; }
        public string Kategoria { get; set; }
        public Versenyzo(string sor)
        {
            string[] sprite = sor.Split(';');

            Nev = sprite[0];
            Születési_év = int.Parse(sprite[1]);
            Rajtszám = int.Parse(sprite[2]);
            Neme = sprite[3];
            Életkor = sprite[4];
            idö1 = sprite[5];
            idö2 = sprite[6];
            idö3 = sprite[7];
            idö4 = sprite[8];
            idö5 = sprite[9];
            Kategoria = sprite[10];
        }
        
    }
}
