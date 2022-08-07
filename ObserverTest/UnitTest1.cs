using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer;
using System;
using System.Collections.Generic;

namespace ObserverTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OserverNotifyTest()
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();
            concreteSubject.Attach(new ConcreteObserver("observer 1", concreteSubject));

            concreteSubject.SubjectState = "Test 1";

            string expected = "observer 1 : observerState update = Test 1";
            List<string> actual = concreteSubject.Notify();

            Assert.AreEqual(expected, actual[0]);


        }
    }
}
