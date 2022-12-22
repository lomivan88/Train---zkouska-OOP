using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Door {
        double height;
        double width;

        public double Height{ get; set; }
        public double Width{ get; set; }

        public Door(double height, double width) {
            this.height = height;
            this.width = width;
        }
    }
}
