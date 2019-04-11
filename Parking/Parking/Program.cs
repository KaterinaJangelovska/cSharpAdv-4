using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            var carParking = new Parking<Car>(50);
            var boatParking = new Parking<Boat>(10);


            var auto1 = new Car("Opel", "Astra", true, false);
            var auto2 = new Car("VW", "Golf", false, false);
            var auto3 = new Car("Opel", "Insignia", true, true);

            var boat1 = new Boat("Kolumbo", true);
            var boat2 = new Boat("SIMS", false);
            var boat3 = new Boat("Katerina", true);

            carParking.ParkVehicle(auto1);
            carParking.ParkVehicle(auto2);
            carParking.ParkVehicle(auto3);

            boatParking.ParkVehicle(boat1);
            boatParking.ParkVehicle(boat2);
            boatParking.ParkVehicle(boat3);

            carParking.LeaveVehicle(auto1);
            boatParking.LeaveVehicle(boat3);


            Console.WriteLine(carParking);
            Console.WriteLine(boatParking);
            Console.ReadLine();
        }
    }
}
