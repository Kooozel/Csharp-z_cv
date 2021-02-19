using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Hopper : IConnectable
    {
        double loadingCapacity;

        public Hopper(double loadingCapacity)
        {
            this.loadingCapacity = loadingCapacity;
        }

        public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }

        public override string ToString()
        {
            return $"Hopper wagon with {loadingCapacity} loading capacity";
        }
        public void DisconnectWagon(Train train)
        {
            if (train.Wagons.Contains(this))
            {
            train.Wagons.Remove(this);

            }
            else
            {
                Console.WriteLine("Wagon is not in train");
            }
        }
        public void ConnectWagon(Train train)
        {
            if (train.Locomotive.Engine.Type == "Steam" && train.Wagons.Count > 4)
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
