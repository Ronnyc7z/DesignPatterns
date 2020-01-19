using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interfaces
{
    public interface IConnection
    {
        public void Connect();
        public void Disconnect();
    }
}
