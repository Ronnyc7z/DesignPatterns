using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Implementation
{
    public class MySQLConnection : IConnection
    {
        private string Host;
        private string Port;
        private string User;
        private string Password;
        public MySQLConnection()
        {
            Host = "localhost";
            Port = "44336";
            User = "RonnyMySQL";
            Password = "4DevOnly!";
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to MySQL");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting to MySQL");
        }
    }
}
