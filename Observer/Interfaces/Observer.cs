using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interfaces
{
    public interface Observer
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
