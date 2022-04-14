using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopOpgaver1.Codes
{
        //public string EjerensKontaktInfo(get; set;)
        //public record EjerensKontaktInfo(string navn, int telefön);
        abstract class Motorkøretøj
        {
            public record EjerensKontaktInfo(string Name, int Phone);
            private DateTime _årgang;

            protected EjerensKontaktInfo KontaktInfo { get; set; }
            protected int? Alder { get; set; }
            public DateTime Årgang
            {
                get
                {
                    return _årgang;
                }
                set
                {
                    _årgang = value;

                    AgeCounter ac = new(_årgang);
                    Alder = ac.Alder;
                }
            }

            public Motorkøretøj()
            {
            }

            public Motorkøretøj(DateTime årgang)
            {
                Årgang = årgang;
            }

            public abstract void SetEjerInfo(string Name, int Phone);
        }
}
