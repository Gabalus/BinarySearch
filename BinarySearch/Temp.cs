using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class Temp : Interface3, Interface2
    {
        public string Str { get; set; }
        int Interface3.b { get; set; }
        int Interface1.s { get; set; }
        int Interface1.z { get; set; }
        int Interface2.f { get; set; }

        public static bool operator & (Temp x, Temp y )
        {
            return x.Str.Length > y.Str.Length ;
        }


    }
}
