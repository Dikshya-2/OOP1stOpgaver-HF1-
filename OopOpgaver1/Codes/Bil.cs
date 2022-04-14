using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopOpgaver1.Codes
{
    sealed class Bil: Motorkøretøj, ISynsInfo
    {
        private string _nummerPladenr;
        public string Errormsg { get; set; }
        public string Mærke { get; set; }
        //public DateTime idstSynet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? SidstSynet { get; set; }

        public string GetNummerPladenr()
        {
            return _nummerPladenr;
        }
        public void SetNummerPladenr(string value)
        {
            _nummerPladenr = value;
        }

        //public int? Alder { get; set; }
        //public record EjerensKontaktInfo(string navn, int telefön);
        public Bil(string nummerpladenr, string mærke)
        {
            SetNummerPladenr(nummerpladenr);
            Mærke = mærke;
            SetEjerInfo("Shaleenta", 1234567);
        }
        public Bil(string nummerpladenr, string mærke, DateTime sidstSynet, DateTime Årgang) : base(Årgang)
        {
            _nummerPladenr = nummerpladenr;
            SetEjerInfo("Dikshys", 457567);
            Mærke = mærke;
            SidstSynet = sidstSynet;
            

            DateTime? dateTime= NæsteSynDato();
            try
            {
                if (dateTime != null)
                {
                    throw new Exception($"Din bil mærke: {mærke},nummerpladenr: {nummerpladenr}, som sidst er synet årgang: {Årgang.ToString("dd.mm.yyyy")} skal til syn senest den {dateTime}");
                    
                }

            }
            catch (Exception ex)
            {
                Errormsg = ex.Message;
                

            }
        }

        public override void SetEjerInfo(string Name, int Phone)
        {
            //throw new NotImplementedException();
            KontaktInfo = new EjerensKontaktInfo(Name, Phone);
        }

        //NæsteSynDato()
        public DateTime? NæsteSynDato()
        {
            AgeCounter ac= new(SidstSynet);
            if (ac.Alder > 2)
                return DateTime.Now.AddMonths(3);
            else return null;
        }
       
    }
}
