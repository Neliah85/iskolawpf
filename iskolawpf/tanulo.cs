using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskolawpf
{
    class tanulo
    {
        public int evszam { get;private set; }
        public string osztaly { get; set; }

        public string nev { get; set; }

        public tanulo(string sor)
        {
            string[] darabok = sor.Split(';');

            this.evszam =Convert.ToInt32(darabok[0]);
            this.osztaly = darabok[1];
            this.nev = darabok[2];
        }

        
        public override string ToString()
        {
            return $"{evszam};{osztaly};{nev}";
        }

       

    }
}
