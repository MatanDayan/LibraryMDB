using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMDB
{
    class BaseX : IComparable<BaseX>
    {
        public double X { get; private set; }
        public BST<HeightY> yTree { get; private set; }
        public BaseX(double PosX )
        {
            this.X = PosX;
            yTree = new BST<HeightY>();
        }
        public int CompareTo(BaseX other)
        {
            if (X == other.X)
            {
                return 0;
            }
            else if (X > other.X)
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
