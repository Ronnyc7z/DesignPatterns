using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interfaces
{
    public interface Subject
    {
        public void RegisterObserver(Observer o);
        public void RemoveObserver(Observer o);
        public void NotifyObservers();
    }
}
