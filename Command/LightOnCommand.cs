using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class LightOnCommand : Command
    {
        public LightOnCommand(Light light)
        {
            this.light = light;
        }


        private Light light { get; }

        public void Execute()
        {
            light.On();
        }
    }

    public class Light
    {
        public void On()
        {
            Console.WriteLine("Lights on");
        }
        public void Off()
        {
            Console.WriteLine("Lights off");
        }
    }
}
