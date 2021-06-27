using System;
using System.Collections.Generic;

namespace Assembly_CSharp.Assets.Scripts.Services
{
    public class EventManager<T>
    {
        private List<EventListener<T>> _listeners = new List<EventListener<T>>();

        public IEventListener<T> Subscribe()
        {
            var newEvent = new EventListener<T>();
            _listeners.Add(newEvent);
            return newEvent;
        }

        public void Unsubscribe(EventListener<T> listener)
        {
            _listeners.Remove(listener);
        }

        public void Notify(T data)
        {
            _listeners.ForEach(listener =>
            {
               listener.OnUpdate(data);
            });
        }

        internal void UnsubscribeAll()
        {
            _listeners.Clear();
        }
    }
}
