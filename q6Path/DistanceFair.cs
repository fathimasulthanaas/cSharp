using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6Path
{
    internal class DistanceFair
    {
        public string starting;
        public string ending;
        public int long_path;
        public int short_path;
        public int fair;
        public int fair_short;
        public DistanceFair(string s, string e, int lp, int sp, int fair, int fair_s)
        {
            this.starting = s;
            this.ending = e;
            this.long_path = lp;
            this.fair_short = fair_s;
            this.fair = fair;
            this.short_path = sp;
        }
    }
}

