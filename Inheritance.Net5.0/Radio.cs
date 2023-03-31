using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Net5._0
{
    // Child Class
    internal class Radio : ElectricalDevice
    {
        //can remove the redudant code after giving it the new class
        /*
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
        }*/

        //moved constructor once commenting out the items above
        public Radio(bool isOn, string brand):base(isOn, brand)
        {
            //can remove after adding the :base to this
            /*Ison = isOn;
            Brand = brand;*/
        }

        //method to listen to the radio

        public void ListenRadio()
        {

            //first check if the radio is on
            if(Ison)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else 
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
