using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public abstract class SoundDevice : Device
    {
        protected ESound soundLevel;
        public SoundDevice(bool state, ESound soundLvl)
            : base(state)
        {
            soundLevel = soundLvl;
        }
        public void SetLevelSoundMute()
        {
            soundLevel = ESound.Mute;
        }
        public void SetLevelSoundMin()
        {
            soundLevel = ESound.Min;
        }
        public void SetLevelSoundMiddle()
        {
            soundLevel = ESound.Middle;
        }
        public void SetLevelSoundMax()
        {
            soundLevel = ESound.Max;
        }
        public override string ToString()
        {
            string state;
            if (this.State)
            {
                state = "включен";
            }
            else
            {
                state = "выключен";
            }

            string sLevel;
            if (soundLevel == ESound.Mute)
            {
                sLevel = "беззвучный режим";
            }
            else if (soundLevel == ESound.Min)
            {
                sLevel = "минимальный";
            }
            else if (soundLevel == ESound.Middle)
            {
                sLevel = "cредний";
            }
            else
            {
                sLevel = "максимальный";
            }
            return "Состояние: " + state + ", уровень громкости: " + sLevel;
        }
    }
}
