using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Chair {
        bool nearWindow;
        int number;
        bool reserved;

        public bool NearWindow { get { return nearWindow; } set { nearWindow = value; } }
        public bool Reserved { get { return reserved; } set { reserved = value; } }
        public int Number { get { return number; } set { number = value; } }

        public Chair(int number, bool nearWindow) {
            this.number = number;
            this.nearWindow = nearWindow;
        }
    }
}
