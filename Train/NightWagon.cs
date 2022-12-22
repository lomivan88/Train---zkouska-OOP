using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class NightWagon:PersonalWagon {
        int numberOfBeds;
        Bed[] beds;
        
        public int NumberOfBeds { get; set; }
        public Bed[] Beds { get; set; }

        public NightWagon(int numberOfChairs, int numberOfBeds):base(numberOfChairs) {
            this.beds = new Bed[numberOfBeds];
        }
    }
}
