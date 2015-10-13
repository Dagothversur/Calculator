using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTests
{
    class Subscriber
    {
        private readonly string _name;
        private readonly Publisher _pub;

        public Subscriber(string name,Publisher pub)
        {
            _name = name;
            _pub = pub;

            _pub.MyEvent += new Publisher.EventHandler(YellMyName);

        }


        public void YellMyName()
        {
            Console.WriteLine("My name is : {0} !",_name);

        }

        public void MoneyCount(MyEventArgs args)
        {
            Console.WriteLine("I have {0} money!",args.Money);

        }

        public void Print(object sender, EventArgs args)
        {
            Console.WriteLine("Object received!");
        }

    }
}
