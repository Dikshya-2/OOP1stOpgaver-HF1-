using OopOpgaver1.Codes;
using System;
using System.Collections.Generic;

namespace OopOpgaver1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bil> list = new List<Bil>();
            Bil bil0 = new Bil("11213x", "BMW", new DateTime(2014, 4, 5), new DateTime (2019,5,3) );          
            Bil bil1 = new Bil("12134AZX", "Audi", new DateTime(2013, 4, 5), new DateTime(2016,4,6));
            Bil bil2 = new Bil("912134ABX", "Opel", new DateTime(2012, 4, 5), new DateTime(2019,3,7));
            Bil bil3 = new Bil("82134BZA", "Opel", new DateTime(2010, 4, 5), new DateTime(2019,4,6));
            list.Add(bil0);
            list.Add(bil1);
            list.Add(bil2);
            list.Add(bil3);

            foreach (var bil in list)
            {
                if (bil.Errormsg != null)

                {
                    Console.WriteLine(bil.Errormsg);
                }
            }



        }
    }
}
