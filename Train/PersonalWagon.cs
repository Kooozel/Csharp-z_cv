using System.Collections.Generic;

namespace Train
{
    class PersonalWagon : IConnectable
    {
        List<Door> doors;
        List<Chair> sits;
        int numberOfChairs;

        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        internal List<Door> Doors { get => doors; set => doors = value; }
        internal List<Chair> Sits { get => sits; set => sits = value; }

        public PersonalWagon(int numberOfChairs)
        {
            this.numberOfChairs = numberOfChairs;
            Sits = new List<Chair>();
            for (int i = 0; i < numberOfChairs; i++)
            {
                Sits.Add(new Chair());
            }

        }
        public override string ToString()
        {
            return $"Personal wagon with {NumberOfChairs} sits";
        }

        public void DisconnectWagon(Train train)
        {
            if (train.Wagons.Contains(this))
            {
                train.Wagons.Remove(this);
            }
            else
            {
                System.Console.WriteLine("Wagon is not in train");
            }

            
        }
        public void ConnectWagon(Train train)
        {
            if (train.Locomotive.Engine.Type == "Steam" && train.Wagons.Count > 5)
            {
                System.Console.WriteLine("Steam engines cannot have more than 5 wagons");
            }
            else
            {
                train.Wagons.Add(this);
            }
            
        }


    }
}
