using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Parking<T> where T : IVehicle
    {
        public int Capacity { get; private set; }
        public int Occupancy { get; private set; }
        public int FreeCapacity { get; /* {return Capacity - Occupancy; } */ set; }

        private List<T> parkedVehicles = new List<T>();

        public Parking(int capacity)
        {
            Capacity = capacity;
            Occupancy = 0;
            
        }

        public void ParkVehicle(T vehicle)
        {
            if(FreeCapacity > 0)
            {
                Occupancy++;
                parkedVehicles.Add(vehicle);
                vehicle.IsParked = true;
                FreeCapacity--;
                Console.WriteLine($"{vehicle} is parked!");
            }
        }

        public void LeaveVehicle(T vehicle)
        {
            foreach (var item in parkedVehicles)
            {
                Occupancy--;
                parkedVehicles.Remove(vehicle);
                vehicle.IsParked = false;
                FreeCapacity++;
                Console.WriteLine($"{vehicle} left the parking!");
            }
        }
    }

    public interface IVehicle
    {
        bool IsParked { get; set; }
        //void LeaveParking();
        Parking<IVehicle> Parking { get; set; }
        void LeaveParking(Parking<IVehicle> parking);

    }
}
