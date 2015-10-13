using System;
using System.Diagnostics.Eventing.Reader;

namespace EventsTests
{
   
    public class MyEventArgs : EventArgs
    {

        public MyEventArgs(int value)
        {
            Money = value;
        }


        public int Money { set; get; }



    }
}