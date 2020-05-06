using Factory.Implementation;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Factory
{
    public class ConnectionFactory
    {
        public static IConnection GetConnection(string connectionType)
        {
            if (connectionType == "YAHORACLE")
                return new OracleConnection();
            else if (connectionType == "MYSQL")
                return new MySQLConnection();
            else
                return new EmptyConnection();
        }
    }
}
