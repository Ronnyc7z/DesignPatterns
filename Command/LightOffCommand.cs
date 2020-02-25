using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class LightOffCommand : Command
    {
        private Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Off();
        }
    }
}
