using System;
using System.Collections.Generic;
using Build;

namespace Tumakov11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ДОМАШНЕЕ ЗАЖАНИЕ 11.1 И 11.2
            Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ 11.1 И 11.2.\n");

            int Building1 = Creator.CreateBuild();
            Creator.CreateBuild(10);
            Creator.CreateBuild(90, 10);
            Creator.CreateBuild(60, 5, 3, 4);

            Dictionary<int, Building> buildingsDictionary = Creator.BuildingsDictionary;
            Console.WriteLine("Созданы здания:\n");

            foreach (Building building in buildingsDictionary.Values)
            {
                Console.WriteLine(building.ToString());
            }

            Creator.RemoveBuilding(Building1);
            Console.WriteLine($"\nУдалено здание под номером {Building1:D2}:\n");

            foreach (Building building in buildingsDictionary.Values)
            {
                Console.WriteLine(building.ToString());
            }

        }
    }
}
