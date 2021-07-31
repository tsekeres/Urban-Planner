using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    class Building
    {
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int Volume => (int)(Width * Depth * (3 * Stories));

        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
            _designer = "Tad Sekeres";
        }
        public void Purchase(string owner)
        {
            _owner = owner;
            Console.WriteLine($"{_address}--------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

    }
}
