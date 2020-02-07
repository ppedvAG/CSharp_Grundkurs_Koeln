using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_Library
{
    public class Yacht : Schiff
    {
        public bool Pool { get; set; }

        public Yacht(string marke, int baujahr, double maxGeschwinigkeit, string farbe, double tiefgang, Antriebskraft antriebskraft, bool pool)
            : base(marke, baujahr, maxGeschwinigkeit, farbe, tiefgang, antriebskraft)
        {
            Pool = pool;
        }
    }
}
