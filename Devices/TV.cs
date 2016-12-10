using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public class TV : SoundDevice
    {
        //private byte channel=1;
        //private byte countChannel;
        //private byte tempChannel;
        //public TV(bool state, ESound soundLevel, byte channel)
        public TV(bool state, ESound soundLevel)
            : base("TV", state)
        {
            this.State = state;
            this.soundLevel = soundLevel;
        }

        //public byte CountChannel
        //{
        //    get
        //    {
        //        return countChannel;
        //    }
        //}
        //public byte MyChannel
        //{
        //    get
        //    {
        //        return channel;
        //    }
        //}
        //public void NextChannel()
        //{
        //    if (channel < countChannel)
        //    {
        //        tempChannel = channel;
        //        channel++;
        //    }
        //}
        //public void PreviouseChannel()
        //{
        //    if (channel > 1)
        //    {
        //        tempChannel = channel;
        //        channel--;
        //    }
        //}
        //public void LastChannel()
        //{
        //    byte temp = channel;
        //    channel = tempChannel;
        //    tempChannel = temp;
        //}

        //public void SetChanel(byte channel)
        //{
        //    if (channel < countChannel && channel > 0)
        //    {
        //        tempChannel = this.channel;
        //        this.channel = channel;
        //    }
        //}
        ////public override string ToString()
        ////{
        ////    string state;
        ////    if (this.State)
        ////    {
        ////        state = "включен";
        ////    }
        ////    else
        ////    {
        ////        state = "выключен";
        ////    }

        ////    string sLevel;
        ////    if (soundLevel == ESound.Mute)
        ////    {
        ////        sLevel = "отключен";
        ////    }
        ////    else if (soundLevel == ESound.Min)
        ////    {
        ////        sLevel = "минимальный";
        ////    }
        ////    else if (soundLevel == ESound.Middle)
        ////    {
        ////        sLevel = "cредний";
        ////    }
        ////    else
        ////    {
        ////        sLevel = "максимальный";
        ////    }
        ////    return "Состояние: " + state + ", уровень громкости: " + sLevel;
            //return "Состояние: " + state + ", уровень громкости: " + sLevel + ", канал: " + channel;
        //}
    }
}
