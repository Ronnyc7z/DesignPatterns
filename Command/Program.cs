using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Light ronnysRoomLight = new Light();            
            Command turnOnLightCommand = new LightOnCommand(ronnysRoomLight);
            Command turnOffLightCommand = new LightOffCommand(ronnysRoomLight);

            SimpleRemoteControl remoteControl = new SimpleRemoteControl();
            remoteControl.SetCommand(turnOnLightCommand);
            remoteControl.PressButton();

            remoteControl.SetCommand(turnOffLightCommand);
            remoteControl.PressButton();
        }
    }
}
