using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class BussinesWagon:PersonalWagon {
        Person steward;

        public Person Steward { get; set; }

        public BussinesWagon(Person steward, int numberOfChairs):base(numberOfChairs) {
            this.steward = steward;
        }
    }
}
