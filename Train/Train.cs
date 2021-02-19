using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Train
    {
        Locomotive locomotive;
        List<IConnectable> wagons = new List<IConnectable>();

        internal Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        internal List<IConnectable> Wagons { get => wagons; set => wagons = value; }

        public Train()
        {
            
        }

        public Train(Locomotive locomotive)
        {
            this.locomotive = locomotive;
            
        }

        public Train(Locomotive locomotive, List<IConnectable> wagons) : this(locomotive)
        {
            this.wagons = wagons;
        }

        public void ConnectWagon(IConnectable wagon)
        {
            wagon.ConnectWagon(this);
        }
        public void DisconnectWagon(IConnectable wagon)
        {
            wagon.DisconnectWagon(this);
        }
        public void ReserveChair(int numberOfWagon, int numberOfSeat)
        {

            if (Wagons[numberOfWagon - 1].GetType().BaseType.Name.Equals("PersonalWagon") || (Wagons[numberOfWagon - 1].GetType().Name.Equals("PersonalWagon")) && numberOfSeat < (Wagons[numberOfWagon - 1] as PersonalWagon).Sits.Count)
            {
                if ((Wagons[numberOfWagon - 1] as PersonalWagon).Sits[numberOfSeat - 1].Reserved == false)
                {
                    (Wagons[numberOfWagon - 1] as PersonalWagon).Sits[numberOfSeat - 1].Reserved = true;
                    Console.WriteLine($"Reserved seat {numberOfSeat} in wagon {numberOfWagon}");
                }

                else
                {
                    Console.WriteLine("Seat already reserved");
                }

            }
            else
            {
                Console.WriteLine("Seat not found");
            }
        }
        public void ListReservedChairs()
        {
            int numberOfWagon = 0;
            foreach (IConnectable item in wagons)
            {
                if (item.GetType().BaseType.Name.Equals("PersonalWagon") || item.GetType().Name.Equals("PersonalWagon"))
                {
                    numberOfWagon++;
                    for (int i = 0; i < (item as PersonalWagon).Sits.Count; i++)
                    {
                        if ((item as PersonalWagon).Sits[i].Reserved == true)
                        {
                            Console.WriteLine($"Reseved seat in wagon {numberOfWagon} seat {i}");
                        }
                    }

                }
            }
        }
        public override string ToString()
        {
            string s;
            s = $"Train 1: {Locomotive} \n";
            foreach (IConnectable item in wagons)
            {
                s += item.ToString() + "\n";
            }
            return s;
        }
    }
}
