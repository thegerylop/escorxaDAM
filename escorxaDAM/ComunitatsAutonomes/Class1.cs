using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexioBBDD;

namespace ComunitatsAutonomes
{
    public class Class1
    {
        static void Main(string[] args)
        {
            using (g2s2am_escorxaDAMDataSet context = new g2s2am_escorxaDAMDataSet())
            {
                context.comunitats_autonomes = (from p in context.comunitats_autonomes
                                                where p.nomComunitatAutonoma == "Catalunya"
                                                select p).FirstOrDefault();
                context.comunitats_autonomes.Addcomunitats_autonomesRow();
            }

        }
    }
}
