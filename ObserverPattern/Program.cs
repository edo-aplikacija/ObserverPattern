using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new youtube channel
            YouTubeChannel Tutorials = new YouTubeChannel();

            ISubscriber edo = new User();
            ISubscriber adi = new Moderator();
            ISubscriber emir = new User();

            Tutorials.Subscribe(edo);
            Tutorials.Subscribe(adi);
            Tutorials.Subscribe(emir);

            // Upload new video
            Tutorials.NotifySubscribers();

            Tutorials.Unsubscribe(edo);
            Console.WriteLine("Edo is no longer subscribed!");

            Tutorials.NotifySubscribers();

            Console.ReadKey();
        }
    }
}
