using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Boat : IVehicle
    {
        public string Name { get; set; }
        public bool BesPlatno { get; set; }

        public Boat(string name, bool besPlatno)
        {
            Name = name;
            BesPlatno = besPlatno;
        }

        public bool IsParked { get; set; }
        public Parking<IVehicle> Parking { get; set; }

        public void LeaveParking(Parking<IVehicle> parking)
        {
            Parking.LeaveVehicle(this);
         //   throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Name}";
           // return base.ToString();
        }
    }
}
