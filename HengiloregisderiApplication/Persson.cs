﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HengiloregisderiApplication
{
    class Persson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Sotu { get; set; }

        public override string ToString()
        {
            return Firstname +" "+ Lastname + " " + Sotu;
        }
    }
}
