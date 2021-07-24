using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planner
{
    class Building
    {
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int Volume { get; private set; }

        string _designer;
        DateTime _dateConstructed;
        string _address;
        string _owner;

        public Building()
        {
            _designer = "Tad Sekeres";
        }

    }
}
