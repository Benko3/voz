﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilooo
{
    internal class Vozilo
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int Kilometraza { get; set; }

        public Vozilo(string marka, string model, int godinaProizvodnje, int kilometraza)
        {
            Marka = marka;
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            Kilometraza = kilometraza;
        }

        
        
    }
}
