using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ObserverPattern
{
    public class ConcreteObserver:Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;
        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.subject = subject;
            this.name = name;
        }


        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者名称{0}的新状态{1}",name,observerState);
        }
    }
}
