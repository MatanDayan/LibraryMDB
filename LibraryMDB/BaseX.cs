using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMDB
{
    class BaseX : IComparable<BaseX>
    {
        double _x;
        BST<HeightY> yTree;

        public int CompareTo(BaseX other)
        {
            if (_x == other._x)
            {
                return 0;
            }
            else if (_x > other._x)
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
