using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal abstract class PersonalWagon : IWagonConnection {
        List<Door> doors;
        List<Chair> sits;
        int numberOfChairs;

        public int NumberOfChairs { get { return numberOfChairs; } }
        public List<Door> Doors { get { return doors; } set { doors = value; } }
        public List<Chair> Sits { get { return sits; } set { sits = value; } }
        public PersonalWagon(int NumberOfChairs) {
            this.numberOfChairs = NumberOfChairs;
            this.doors = new List<Door>();
            this.sits = new List<Chair>(numberOfChairs);

        }

        public void ConnectWagon(Train train) {
            if (train.Locomotive.Engine.Type == "steam" && train.Wagons.Count >= 5 ) {
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
