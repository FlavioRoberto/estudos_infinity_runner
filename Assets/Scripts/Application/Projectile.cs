using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class Projectile : MonoBehaviour
    {
        private Rigidbody2D _rigidBody;
        public int Damage = 1;
        public float Speed = 10;

        void Start()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
            Destroy(gameObject, 3f);
        }

        void FixedUpdate()
        {
            _rigidBody.velocity = Vector2.right * Speed;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(gameObject);
        }

    }
}
