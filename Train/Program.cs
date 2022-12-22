using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Program {
        static void Main(string[] args) {
            Person lenka = new Person("Lenka", "Novakova");
            Engine diesel = new Engine("diesel");
            Engine steam = new Engine("steam");
            BussinesWagon b1 = new BussinesWagon(lenka, 15);
            EconomyWagon e1 = new EconomyWagon(20);
            Hopper h1 = new Hopper(1200);
            Locomotive naftak = new Locomotive(new Person("Karel", "Novak"), diesel);
            Train vlak1 = new Train(naftak);
            Train vlak2 = new Train(new Locomotive(lenka, steam));

            vlak2.ConnectWagon(b1);
            vlak2.ConnectWagon(e1);
            vlak2.ConnectWagon(h1);
            vlak2.ConnectWagon(b1);
            vlak2.ConnectWagon(e1);
            vlak2.ConnectWagon(h1);
            vlak2.ConnectWagon(h1);
            vlak2.DissconectWagon(h1);
            vlak2.DissconectWagon(e1);
            vlak2.DissconectWagon(e1);
            vlak2.DissconectWagon(e1);


            Console.WriteLine(vlak2.ToString());
        }
    }
}
