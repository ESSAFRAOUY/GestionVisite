using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVisite.model
{
   public class Helper
    {
        public static double Distance(Personne cli1, Personne cli2)
        {

            return Distance(cli1.Position, cli2.Position);
        }

        private static double Distance(Geometry p1, Geometry p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
}
