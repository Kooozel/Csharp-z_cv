using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class TestTrain
    {
        public static void Mainx(string[] args)
        {
            PersonalWagon p1 = new PersonalWagon(40);
            PersonalWagon p2 = new PersonalWagon(70);
            BusinessWagon b1 = new BusinessWagon(25, new Person("Lenka", "Kozakova"));
            NightWagon n1 = new NightWagon(15, 15);
            Hopper h1 = new Hopper(15);
            Locomotive locomotive = new Locomotive(new Person("Karel", "Novak"), new Engine("Diesel"));

            Train train1 = new Train(locomotive,new List<IConnectable> {p1,p2,b1,n1,h1 });

            //Console.WriteLine(train1);

            Train train2 = new Train(new Locomotive(new Person("Karel", "Ovarek"), new Engine("Steam")), new List<IConnectable> { p1, p2, b1, n1, h1 });
            Hopper h2 = new Hopper(20);

            //train2.ConnectWagon(h2);



            train1.ReserveChair(3, 5);
            train1.ReserveChair(1, 10);
            train1.ReserveChair(5, 7);
            train1.ReserveChair(3, 5);
            train1.ReserveChair(2, 85);

            train1.ListReservedChairs();


            Console.WriteLine(train1);
            Console.WriteLine(train2);


            //Train train3 = new Train(locomotive);

            //train3.ConnectWagon(h2);
            //train3.ConnectWagon(h1);

            //Console.WriteLine(train3);


        }
    }
}
