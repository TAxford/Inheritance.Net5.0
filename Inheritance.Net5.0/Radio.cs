using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Net5._0
{
    internal class Radio
    {
        //boolean to determine the state of the Radio

        public bool Ison { get; set; }
        //string for the brand name of the radio

        public string Brand { get; set; }

        //basic constructor

        public Radio(bool isOn, string brand)
        {

            Ison = isOn;
            Brand = brand;
        }


        //added methods
        //switch on the radio

        public void SwitchOn()
        {
            Ison = true;
        }
        //switch off the radio

        public void SwitchOff() 
        {
            Ison= false;
        }


    }
}
