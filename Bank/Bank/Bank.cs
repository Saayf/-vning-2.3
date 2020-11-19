using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        /*
         * Detta var original planen, men det var enklare med en list.
         * public BankKonto[] konton;
        */

        public List<BankKonto> konton = new List<BankKonto>();

        public Bank()
        {

        }

        public double Behållning()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
