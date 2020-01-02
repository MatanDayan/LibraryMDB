using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMDB
{
    class HeightY: IComparable<HeightY>
    {
        public double _y { get; private set; }
        public int _amount { get;  set; }
        

        public HeightY(double y ,int amount )
        {
            _y = y;
            _amount = amount;
        }

        public int CompareTo(HeightY other)
        {
            if (_y == other._y)
            {
                return 0;
            }
            else if (_y > other._y)
            {
                return 1;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
