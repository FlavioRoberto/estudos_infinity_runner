using Assembly_CSharp.Assets.Scripts.Application.Base;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class FlyEnemy : EnemyApplication
    {
        public float Speed = 10;
        public float timeDestroy = 5;
        private Rigidbody2D _rigidbody;

        protected override void Start()
        {
            base.Start();
            _rigidbody = GetComponent<Rigidbody2D>();
            Destroy(gameObject, timeDestroy);
        }

        void FixedUpdate()
        {
            _rigidbody.velocity = Vector2.left * Speed;
        }
    }
}