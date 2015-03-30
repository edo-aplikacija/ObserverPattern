using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    class YouTubeChannel
    {
        private IList<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        /// <summary>
        /// <para>line1</para>
        /// <para>line2</para>
        /// </summary>
        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Notify();
            }
        }
    }
}
