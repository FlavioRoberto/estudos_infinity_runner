using System;

namespace Assembly_CSharp.Assets.Scripts.Services
{
    public class EventListener<T> : IEventListener<T>
    {
        private Action<T> Action;

        public void OnUpdate(T data)
        {
            Action(data);
        }

        public void Then(Action<T> action)
        {
            Action = action;
        }
    }

    public interface IEventListener<T>{
        void Then(Action<T> action);
    }
}
