using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Locomotive {
        Person driver;
        Engine engine;

        public Person Driver { get { return driver; } set { driver = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }

        public Locomotive() {}
        public Locomotive(Person driver, Engine engine) {
            this.driver = driver;
            this.engine = engine;
        }
    }
}
