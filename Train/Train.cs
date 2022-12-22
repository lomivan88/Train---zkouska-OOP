using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Train {
        Locomotive locomotive;
        List<IWagonConnection> wagons;

        public Locomotive Locomotive { get { return locomotive; } set { locomotive = value; } }
        public List<IWagonConnection> Wagons { get { return wagons; } set { wagons = value; } }


        public Train() {
            this.locomotive = null;
            this.wagons = new List<IWagonConnection>();

        }
        public Train(Locomotive locomotive) {
            this.locomotive = locomotive;
            this.wagons = new List<IWagonConnection>();
        }
        public Train(Locomotive locomotive, List<IWagonConnection> wagons) : this(locomotive) {
            this.wagons = wagons;
        }
        public void ConnectWagon(IWagonConnection wagonType) {
            wagonType.ConnectWagon(this);
        }
        public void DissconectWagon(IWagonConnection wagonType) {
            wagonType.DisconnectWagon(this);
        }
        public void ReserveChair(int vagon_nr, int chair_nr) {
            if ((wagons[vagon_nr]).GetType() == typeof(PersonalWagon) && chair_nr >= 0 && chair_nr < ((PersonalWagon)Wagons[vagon_nr]).NumberOfChairs) {
                if (((PersonalWagon)wagons[vagon_nr]).Sits[chair_nr].Reserved is true) {
                    Console.WriteLine("Sits is reserved");
                }
                else {
                    ((PersonalWagon)wagons[vagon_nr]).Sits[chair_nr].Reserved = true;
                }
            }
        }
        public void ListReservedChairs() {
            foreach (PersonalWagon wagon in wagons) {
                foreach (Chair chairs in wagon.Sits) {
                    if (chairs.Reserved) {
                        Console.WriteLine(chairs.Number);
                    }
                }
            }
        }
        public override string ToString() {
            string vagony = "";
            foreach (IWagonConnection item in wagons) {
                vagony += item.GetType().Name + " ";
            }
            return $"{this.GetType().Name}: {vagony} ";
        }
    }
}
