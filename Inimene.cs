using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum05
{
    class Inimene
    {
        public string Eesnimi;
        public string Perenimi;
        public int Pikkus;

        public override string ToString()
        {
            return $"{Eesnimi} {Perenimi} {Pikkus}";
        }

 
    }
}
