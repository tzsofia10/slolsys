using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slolsys
{
   internal class ora
    {
        public string name { get; set; }
        public int holdszam { get; set; }
        public double bolygoter { get; set; }

        public ora(string sorok)
        {
            string[] sor = sorok.Split(";");
            name = sor[0];
            holdszam = Convert.ToInt32(sor[1]);
            bolygoter = Convert.ToDouble(sor[2]);
        }

    }
}
