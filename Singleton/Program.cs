using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection databaseConnection = DatabaseConnection.GetDatabaseConnection();
            databaseConnection.Connect();
            databaseConnection.Disconnect();
        }
    }
}
