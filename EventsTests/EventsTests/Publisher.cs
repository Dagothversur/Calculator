using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTests
{
    public class Publisher
    {
        //our delegate
       
        public  delegate void EventHandler(); //It is delegate(default or my own created)

        //our event
        public event EventHandler MyEvent;  //event with delage type(underlying subscirber list)


        internal delegate void SecondEventHandler(MyEventArgs args);

        internal event SecondEventHandler SecondEvent;

        public event System.EventHandler Click;


        //MyEvent can be null-no subscribers
        private void RaiseEvent()
        {
            //Raise an event
            MyEvent?.Invoke();
            Click?.Invoke(this,EventArgs.Empty);


            SecondEvent?.Invoke( new MyEventArgs(1000) );

        }

        public void Ready()
        {            
            RaiseEvent();
        }

        protected virtual void OnClick(System.EventArgs)
        {
            FileSystemWatcher
        }




    }

    
}
