using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class FlyEnemy : MonoBehaviour
    {
        public float Speed = 10;
        public float timeDestroy = 5;
        private Rigidbody2D _rigidbody;

        void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            Destroy(gameObject, timeDestroy);
        }

        void FixedUpdate()
        {
            _rigidbody.velocity = Vector2.left * Speed;
        }
    }
}