using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Capital
    {

        public int PopulationX { get; set; }
        public int PopulationY { get; set; }


        public static bool operator <(Capital p1, Capital p2)
        {
            return p1.PopulationX < p2.PopulationY;

        }

        public static bool operator >(Capital p1, Capital p2)
        {
            return p1.PopulationX > p2.PopulationY;

        }

        public override string ToString()
        {
            return $"{PopulationX}, {PopulationY}";
        }

    }
}
