using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public class TV : SoundDevice
    {
        public TV(bool state, ESound soundLevel)
            : base(state, ESound.Middle)
        {
            this.soundLevel = soundLevel;
        }
    }
}
