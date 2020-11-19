using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SparKonto : BankKonto
    {
        public SparKonto(string personNummer, double behållning, double ränteSats) :  base(personNummer, behållning, ränteSats)
        {

        }

        public override double BeräknaRänta()
        {
            double procentuellRänta = behållning * ränteSats;
            return behållning = behållning + procentuellRänta;
        }

        public override bool Uttag(double belopp)
        {
            if (belopp < behållning)
            {
                behållning -= belopp;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
