using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse2
{
    public class Lamp : Device
    {
        private EColour colour;
        public Lamp(bool state, EColour colour)
            : base(state)
        {
            this.colour = colour;
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
            return string.Format("Состояние: {0}, цвет: {1}", state, colour);
        }
    }
}
