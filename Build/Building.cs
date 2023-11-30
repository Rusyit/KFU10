namespace Build
{
    public class Building
    {
        private static int numOfBuildings;
        private int buildingNum;
        private double buildingHeight;
        private int numOfFloors;
        private int numOfAparts;
        private int numOfEntrances;

        public int BuildingNum
        {
            get
            {
                return buildingNum;
            }
        }

        public double BuildingHeight
        {
            get
            {
                return buildingHeight;
            }
        }

        public int NumOfFloors
        {
            get
            {
                return numOfFloors;
            }
        }

        public int NumOfAparts
        {
            get
            {
                return numOfAparts;

            }
        }

        public int NumOfEntrances
        {
            get
            {
                return numOfEntrances;
            }
        }

        public double CalculationFloorHeight()
        {
            return buildingHeight / numOfFloors;
        }

        public int CalculationNumberOfApartmentsInEntrance()
        {
            return NumOfAparts / NumOfEntrances;
        }

        public int CalculationNumberOfApartmentsOnFloor()
        {
            return (NumOfAparts / NumOfEntrances) / numOfFloors;
        }

        private void ChangeNumberOfBuilding()
        {
            numOfBuildings++;
        }

        public override string ToString()
        {
            return $"Здание №{buildingNum:D2} высотой {buildingHeight} содержит {NumOfAparts} квартир, {numOfFloors} этажей, {NumOfEntrances} подъездов";
        }

        internal Building(int buildingHeight, int numOfFloors, int numOfAparts, int numOfEntrances)
        {
            this.buildingHeight = buildingHeight;
            this.numOfFloors = numOfFloors;
            this.numOfAparts = numOfAparts;
            this.numOfEntrances = numOfEntrances;
            buildingNum = numOfBuildings;
            ChangeNumberOfBuilding();
        }

        internal Building(int buildingHeight, int numOfFloors)
        {
            this.buildingHeight = buildingHeight;
            this.numOfFloors = numOfFloors;
            numOfAparts = 75;
            numOfEntrances = 5;
            buildingNum = numOfBuildings;
            ChangeNumberOfBuilding();
        }

        internal Building(int numbEntrances)
        {
            this.numOfEntrances = numOfEntrances;
            buildingHeight = 80;
            numOfFloors = 20;
            numOfAparts = 100;
            buildingNum = numOfBuildings;
            ChangeNumberOfBuilding();
        }

        internal Building()
        {
            buildingHeight = 200;
            numOfFloors = 50;
            numOfAparts = 100;
            numOfEntrances = 1;
            buildingNum = numOfBuildings;
            ChangeNumberOfBuilding();
        }
    }
}
