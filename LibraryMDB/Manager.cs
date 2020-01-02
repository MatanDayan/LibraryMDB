using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMDB
{
    public class Manager
    {
        BST<BaseX> mainTree = new BST<BaseX>();


        public void ReFill(double x, double y, int amount)
        {
            BaseX baseX = new BaseX(x);
            BaseX baseFound;
            HeightY heightY = new HeightY(y, amount);
            HeightY yFound;

            bool isXFound = mainTree.Search(baseX, out baseFound);
            if (isXFound == false)
            {
                mainTree.Add(baseX);
                baseX.yTree.Add(heightY);
               
            }
            else
            {
                bool isYFound =  baseFound.yTree.Search(heightY, out yFound);
                if (isYFound == false)
                {
                    baseFound.yTree.Add(heightY);

                }
                else
                {
                    yFound._amount += amount;
                }
            }

        }

    }
}
