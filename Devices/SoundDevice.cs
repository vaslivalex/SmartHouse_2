using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public abstract class SoundDevice : Device
    {
        protected ESound soundLevel;
        public SoundDevice(bool state, ESound soundLevel)
            : base(state)
        {
            this.soundLevel = soundLevel;
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

            //string sLevel = ESound2String(soundLevel);
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
            return string.Format("Состояние: {0}, уровень громкости: {1}", state, sLevel);
        }

        //public string ESound2String(ESound eSound)
        //{
        //    if (!Enum.IsDefined(typeof(ESound), eSound))
        //    {
        //        return string.Empty;
        //    }

        //    switch (eSound)
        //    {
        //        case ESound.Mute:
        //            return "беззвучный режим";
        //        case ESound.Min:
        //            return "минимальный";
        //        case ESound.Middle:
        //            return "cредний";
        //        case ESound.Max:
        //            return "максимальный";
        //        default:
        //            return string.Empty;
        //    }
        //}
    }
}
