using System;
using Assembly_CSharp.Assets.Scripts.Services;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class Platform : MonoBehaviour
    {
        private EventManager<bool> _eventManager;

        public IEventListener<bool> OnRecycleNotify { get { return _eventManager.Subscribe(); } }

        public Transform FinalPoint;

        void Start()
        {
            _eventManager = new EventManager<bool>();
        }

        public void OnRecycle()
        {
            _eventManager.Notify(true);
        }

        void OnDestroy()
        {
            _eventManager.UnsubscribeAll();
        }
    }

}