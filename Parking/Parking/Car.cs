using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Car : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDiesel { get; set; }
        public bool IsElectric { get; set; }

        public Car(string make, string model, bool isDiesel, bool isElectric)
        {
            Make = make;
            Model = model;
            IsDiesel = isDiesel;
            IsElectric = isElectric;
            
        }

        public bool IsParked { get; set; }
        public Parking<IVehicle> Parking { get; set; }

        public void LeaveParking(Parking<IVehicle> parking)
        {
            Parking.LeaveVehicle(this);
           // throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Make} {Model}";
           // return base.ToString();
        }
    }
}
