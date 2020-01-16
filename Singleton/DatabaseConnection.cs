using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection databaseConnectionInstance;
        private DatabaseConnection()
        {

        }
        public static DatabaseConnection GetDatabaseConnection()
        {
            if (databaseConnectionInstance == null)
                databaseConnectionInstance = new DatabaseConnection();

            return databaseConnectionInstance;
        }

        public void Connect()
        {
            Console.WriteLine("Connected to the database");
        }
        public void Disconnect()
        {
            Console.WriteLine("Disconnected");
        }
    }
}
