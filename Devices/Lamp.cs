using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public class Lamp : Device
    {
        private EColour colour;
        public Lamp(bool state, EColour clr)
            : base(state)
        {
            colour = clr;
        }
        public void SetRedColor()
        {
            colour = EColour.Red;
        }
        public void SetGreenColor()
        {
            colour = EColour.Green;
        }
        public void SetBlueColor()
        {
            colour = EColour.Blue;
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
            string colour;
            if (this.colour == EColour.Red)
            {
                colour = "красный";
            }
            else if (this.colour == EColour.Green)
            {
                colour = "зеленый";
            }
            else
            {
                colour = "синий";
            }
            return "Состояние: " + state + ", цвет: " + colour;
        }
    }
}
