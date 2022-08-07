using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserver : AObserver
    {
        public string Name { get; set; }
        private string ObserverState { get; set; }
        public ConcreteSubject ConcreteSubject { get; set; }

        public ConcreteObserver(string Name, ConcreteSubject concreteSubject)
        {
            this.Name = Name;
            this.ConcreteSubject = concreteSubject;
        }

        public override string Update()
        {
            ObserverState = ConcreteSubject.SubjectState;
            return $"{Name } : observerState update = {ConcreteSubject.SubjectState}";
        }
    }
}
