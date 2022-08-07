using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> msgList = new List<string>();

            ConcreteSubject concreteSubject = new ConcreteSubject();
            concreteSubject.Attach(new ConcreteObserver("observer 1", concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("observer 2", concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("observer 3", concreteSubject));

            var observer4 = new ConcreteObserver("observer 4", concreteSubject);
            concreteSubject.Attach(observer4);

            concreteSubject.SubjectState = "Test 1";
            msgList = concreteSubject.Notify();

            foreach (var item in msgList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------");
            concreteSubject.Detach(observer4);
            concreteSubject.SubjectState = "Test 2";
            msgList = concreteSubject.Notify();

            foreach (var item in msgList)
            {
                Console.WriteLine(item);
            }

            Console.Read();

        }
    }
}
