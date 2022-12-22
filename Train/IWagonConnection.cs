﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal interface IWagonConnection {
        void ConnectWagon(Train train);
        void DisconnectWagon(Train train);
    }
}
