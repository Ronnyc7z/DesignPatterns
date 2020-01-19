using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Implementation
{
    public class EmptyConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Not a valid provider");
        }

        public void Disconnect()
        {
            Console.WriteLine("Not a valid provider");
        }
    }
}
