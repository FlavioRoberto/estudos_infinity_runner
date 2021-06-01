using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public float Speed;
        public float ForceJump;
        private Rigidbody2D _rigidBody;

        void Start()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            MoveRight();
            Jump();
        }

        private void MoveRight()
        {
            _rigidBody.velocity = new Vector2(Speed, _rigidBody.velocity.y);
        }

        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _rigidBody.AddForce(Vector2.up * ForceJump, ForceMode2D.Impulse);
        }
    }
}
