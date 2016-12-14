using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public class Phone:SoundDevice
    {
        private ESound ringtonVolume;
        public Phone(bool state, ESound ringtonVolume)
            : base(state, ESound.Min)
        {
            this.ringtonVolume = ringtonVolume;
        }

    }
}
