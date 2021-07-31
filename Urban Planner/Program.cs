using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var BuildingOne = new Building("512 8th Avenue");
            BuildingOne.Depth = 120;
            BuildingOne.Stories = 8;
            BuildingOne.Width = 50;

            BuildingOne.Construct();
            BuildingOne.Purchase("Bill Purcell");

            var BuildingTwo = new Building("1145 6th Street");
            BuildingTwo.Depth = 100;
            BuildingTwo.Stories = 8;
            BuildingTwo.Width = 40;

            BuildingTwo.Construct();
            BuildingTwo.Purchase("Ron Nollner");

            var BuildingThree = new Building("1600 Pennsylvania");
            BuildingThree.Depth = 90;
            BuildingThree.Stories = 8;
            BuildingThree.Width = 50;

            BuildingThree.Construct();
            BuildingThree.Purchase("Jill Petty");

            var BuildingFour = new Building("810 Streety Street");
            BuildingFour.Depth = 130;
            BuildingFour.Stories = 8;
            BuildingFour.Width =25;

            BuildingFour.Construct();
            BuildingFour.Purchase("Don Rickles");
        }
    }
}
