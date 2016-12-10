using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public class Microwave : Device
    {
        private EModeMicrowave mode;
        public Microwave (bool state, EModeMicrowave mode)
            :base("Микроволновка", state)
        {
            this.State = state;
            this.mode = mode;
        }
        public void SetPowerDefrost()
        {
            mode = EModeMicrowave.Defrost;
        }
        public void SetPowerMin()
        {
            mode = EModeMicrowave.Min;
        }
        public void SetPowerMiddle()
        {
            mode = EModeMicrowave.Middle;
        }
        public void SetPowerMax()
        {
            mode = EModeMicrowave.Max;
        }
        public override string ToString()
        {
            string state;
            if (this.State)
            {
                state = "включена";
            }
            else
            {
                state = "выключена";
            }
            string mode;
            if (this.mode == EModeMicrowave.Min)
            {
                mode = "минимальной мощности";
            }
            else if (this.mode == EModeMicrowave.Middle)
            {
                mode = "средней мощности";
            }
            else if (this.mode == EModeMicrowave.Defrost)
            {
                mode = "разморозки";
            }
            else
            {
                mode = "максимальной мощности";
            }
            return "Состояние: " + state + ", режим: " + mode;
        }
    }
}
