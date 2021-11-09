using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    interface Interface1
    {
        public int s { get; set; }
        public int z { get; set; }

    }

    interface Interface2 : Interface1
    {
        public int f { get; set; }
    }

    interface Interface3 : Interface1
    {
        public int b { get; set; }

    }
}
