using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Factory Pattern demo:");

            Console.WriteLine("\nCreating MYSQL connection");
            var mySqlConnection = ConnectionFactory.GetConnection("MYSQL");
            mySqlConnection.Connect();
            mySqlConnection.Disconnect();

            Console.WriteLine("\nCreating ORACLE connection");
            var oracleConnection = ConnectionFactory.GetConnection("ORACLE");
            oracleConnection.Connect();
            oracleConnection.Disconnect();

            Console.WriteLine("\nCreating a random connection");
            var randomConnection = ConnectionFactory.GetConnection("MONGODB");
            randomConnection.Connect();
            randomConnection.Disconnect();
        }
    }
}
