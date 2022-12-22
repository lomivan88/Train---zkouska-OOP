using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Hopper:IWagonConnection {
        double loadingCapacity;

        public double LoadingCapacity { get { return loadingCapacity; } set { loadingCapacity = value; } }

        public Hopper(double tonnage) {
            this.loadingCapacity = tonnage;
        }
        public void ConnectWagon(Train train) {
            if (train.Locomotive.Engine.Type == "steam" && train.Wagons.Count >= 5) {
                Console.WriteLine("You cannot connect next wagon (steam engine maximum)!");
            }
            else {
                train.Wagons.Add(this);
            }
        }

        public void DisconnectWagon(Train train) {
            if (train.Wagons.Contains(this)) {
                train.Wagons.Remove(this);
            }
            else {
                Console.WriteLine("Train does not contain this wagon!");
            }
        }
    }
}
