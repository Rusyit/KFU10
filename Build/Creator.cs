using System.Collections.Generic;

namespace Build
{
    public static class Creator
    {

        private static Dictionary<int, Building> buildingsDictionary = new Dictionary<int, Building>();

        public static Dictionary<int, Building> BuildingsDictionary
        {
            get
            {
                return buildingsDictionary;
            }
        }

        public static int CreateBuild(int buildingHeight, int numOfFloors, int numOfAparts, int numOfEntrances)
        {
            Building building = new Building(buildingHeight, numOfFloors, numOfAparts, numOfEntrances);
            buildingsDictionary.Add(building.BuildingNum, building);
            return building.BuildingNum;
        }

        public static int CreateBuild(int buildingHeight, int numOfFloors)
        {
            Building building = new Building(buildingHeight, numOfFloors);
            buildingsDictionary.Add(building.BuildingNum, building);
            return building.BuildingNum;
        }

        public static int CreateBuild(int numOfEntrances)
        {
            Building building = new Building(numOfEntrances);
            buildingsDictionary.Add(building.BuildingNum, building);
            return building.BuildingNum;
        }

        public static int CreateBuild()
        {
            Building building = new Building();
            buildingsDictionary.Add(building.BuildingNum, building);
            return building.BuildingNum;
        }

        public static void RemoveBuilding(int buildingNum)
        {
            buildingsDictionary.Remove(buildingNum);
        }
    }
}
