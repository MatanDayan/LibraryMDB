using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMDB
{
    class TimeData
    {
        DateTime DateTime = new DateTime();
        Double x, y;

        public TimeData(DateTime dateTime , Double Px , Double Py   )
        {
            this.DateTime = dateTime;
            this.x = Px;
            this.y = Py;
            public int MyProperty { get; set; }

        }






    }
}
