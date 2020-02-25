using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SimpleRemoteControl
    {
        Command slot;

        public void SetCommand(Command command)
        {
            slot = command;
        }

        public void PressButton()
        {
            slot.Execute();
        }
    }
}
