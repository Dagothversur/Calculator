using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventsTests
{
    class Program
    {
        

        static void Main(string[] args)
        {
            


            Publisher publisher = new Publisher(); //object of our publisher
            Subscriber sub = new Subscriber("Paweł",publisher);
            publisher.SecondEvent += new Subscriber("Szymon", publisher).MoneyCount;

            
           

         
            //delegate inference
           

            publisher.Ready();//raising event
            Console.ReadKey();

        }
    }



}
