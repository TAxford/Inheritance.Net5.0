using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Net5._0
{
    internal class TV
    {
        //boolean to determine the state of the tv

        public bool Ison { get; set; }
        //string for the brand name of the tv

        public string Brand { get; set; }

        //basic constructor

        public TV(bool isOn, string brand)
        {

            Ison = isOn;
            Brand = brand;
        }
    }
}
