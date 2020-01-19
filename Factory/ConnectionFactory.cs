using Factory.Implementation;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ConnectionFactory
    {
        public IConnection GetConnection(string connectionType)
        {
            if (connectionType == "ORACLE")
                return new OracleConnection();
            else if (connectionType == "MYSQL")
                return new MySQLConnection();
            else
                return new EmptyConnection();
        }
    }
}
