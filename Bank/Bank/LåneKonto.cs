using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class LåneKonto : BankKonto
    {

        private double kreditGräns;

        public LåneKonto(string personNummer, double behållning, double ränteSats, double kreditGräns) : base(personNummer, behållning, ränteSats)
        {
            this.kreditGräns = kreditGräns;
        }

        public override double BeräknaRänta()
        {
            double procentuellRänta = behållning * ränteSats;
            return behållning = behållning - procentuellRänta;
        }

        public override bool Uttag(double belopp)
        {
            if (behållning - belopp >= kreditGräns)
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
