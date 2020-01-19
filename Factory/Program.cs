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
            ConnectionFactory connectionFactory = new ConnectionFactory(); 

            Console.WriteLine("\nCreating MYSQL connection");
            var mySqlConnection = connectionFactory.GetConnection("MYSQL");
            mySqlConnection.Connect();
            mySqlConnection.Disconnect();

            Console.WriteLine("\nCreating ORACLE connection");
            var oracleConnection = connectionFactory.GetConnection("ORACLE");
            oracleConnection.Connect();
            oracleConnection.Disconnect();

            Console.WriteLine("\nCreating a random connection");
            var randomConnection = connectionFactory.GetConnection("MONGODB");
            randomConnection.Connect();
            randomConnection.Disconnect();

        }
    }
}
