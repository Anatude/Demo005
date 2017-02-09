using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumiApplication
{
    class Track
    {
        public string Trackname { get; set; }
        public string Tracklenght { get; set; }

        public override string ToString()
        {
            return Trackname + " " + Tracklenght;
        }
    }
}
