using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Implementation
{
    public class OracleConnection: IConnection
    {
        private string Host;
        private string Port;
        private string User;
        private string Password;
        public OracleConnection()
        {
            Host = "localhost";
            Port = "33516";
            User = "RonnyOC";
            Password = "YAhoracle?";
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to Oracle");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from Oracle");
        }
    }
}
