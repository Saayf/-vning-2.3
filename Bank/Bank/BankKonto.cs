using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class BankKonto
    {

        protected string personNummer;
        protected double behållning;
        protected double ränteSats;

        public BankKonto(string personNummer, double behållning, double ränteSats)
        {
            this.personNummer = personNummer;
            this.behållning = behållning;
            this.ränteSats = ränteSats;
        }

        public abstract bool Uttag(double belopp);
        public abstract double BeräknaRänta();

        public double Behållning()
        {
            return behållning;
        }

        public void Insättning(double belopp)
        {
            behållning += belopp;
        }

        public override string ToString()
        {
            if(this is LåneKonto)
            {
                return "Lånekonto: " + personNummer + ": " + behållning;
            }
            else if (this is SparKonto)
            {
                return "Sparkonto: " + personNummer + ": " + behållning;
            }

            return "Felaktighet.";
        }

    }
}
