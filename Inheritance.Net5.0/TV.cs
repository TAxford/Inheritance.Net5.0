using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Net5._0
{
    // Child Class
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

        //added methods
        //switch on the tv

        public void SwitchOn()
        {
            Ison = true;
        }
        //switch off the tv

        public void SwitchOff()
        {
            Ison = false;
        }

        //method to watch the TV

        public void WatchTV()
        {

            //first check if the radio is on
            if (Ison)
            {
                //watch the TV
                Console.WriteLine("Watching TV");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
