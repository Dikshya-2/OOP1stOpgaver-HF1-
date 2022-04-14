using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopOpgaver1.Codes
{
    struct AgeCounter
    {
        public int? Alder
        { get; set; }

        // public  AgeCounter (DateTime Årgang): this()
        //we can represent in both way
        public AgeCounter(DateTime? Årgang):this() 

        {//Alder = null;

            Alder = Result (Årgang);
        }

        private int Result (DateTime? Årgang)
        {
            // return  DateTime.Now.Year - Årgang.Year

            int differance = DateTime.Now.Year - ((DateTime)Årgang).Year;
            return differance;
        }
    }
}
