using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public abstract class Device
    {
        public string Name { get; set; }
        public bool State { get; set; }
        public Device(string name, bool state)
        {
        }
        public void On()
        {
            State = true;
        }
        public void Off()
        {
            State = false;
        }
    }
}
