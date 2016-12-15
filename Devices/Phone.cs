using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public class Phone:SoundDevice
    {
        private EBright brightScreen;
        public Phone(bool state, ESound soundLevel, EBright brightScreen)
            : base(state, ESound.Min)
        {
            this.soundLevel = soundLevel;
            this.brightScreen = brightScreen;
        }
        public void SetLevelBrightScreenOff()
        {
            brightScreen = EBright.Off;
        }
        public void SetLevelBrightScreenLow()
        {
            brightScreen = EBright.Low;
        }
        public void SetLevelBrightScreenMiddle()
        {
            brightScreen = EBright.Middle;
        }
        public void SetLevelBrightScreenMax()
        {
            brightScreen = EBright.Max;
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

            string brightScreenLevel;
            if (brightScreen == EBright.Off)
            {
                brightScreenLevel = "выключена";
            }
            else if (brightScreen == EBright.Low)
            {
                brightScreenLevel = "минимальная";
            }
            else if (brightScreen == EBright.Middle)
            {
                brightScreenLevel = "cредняя";
            }
            else
            {
                brightScreenLevel = "максимальная";
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
            return "Состояние: " + state + ", " + "подсветка экрана: " + brightScreenLevel + ", уровень громкости: " + sLevel;
        }
    }
}
