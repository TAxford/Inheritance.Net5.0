using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Net5._0
{
    internal class ElectricalDevice
    {
        //boolean to determine the state of the Electrical Device

        public bool Ison { get; set; }
        //string for the brand name of the Electrical Device

        public string Brand { get; set; }

        //basic constructor

        public ElectricalDevice(bool isOn, string brand)
        {

            Ison = isOn;
            Brand = brand;
        }


        //added methods
        //switch on the Electrical Device

        public void SwitchOn()
        {
            Ison = true;
        }
        //switch off the Electrical Device

        public void SwitchOff()
        {
            Ison = false;
        }
    }
}
