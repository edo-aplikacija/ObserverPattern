using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    class Moderator : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Moderator needs to review new video!");
        }
    }
}
