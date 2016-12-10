using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public class Phone:SoundDevice
    {
        public ESound ringtonVolume;
        public Phone(bool state, ESound ringtonVolume)
            : base("Телефон", state)
        {
            this.State = state;
            this.ringtonVolume = ringtonVolume;
        }

    }
}
