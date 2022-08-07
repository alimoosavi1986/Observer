using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class ASubject
    {
        private List<AObserver> observers = new List<AObserver>();

        public void Attach(AObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(AObserver observer)
        {
            observers.Remove(observer);
        }

        public List<string> Notify()
        {
            List<string> msg = new List<string>();
            foreach (var item in observers)
            {
                msg.Add(item.Update());
            }

            return msg;
        }

    }
}
