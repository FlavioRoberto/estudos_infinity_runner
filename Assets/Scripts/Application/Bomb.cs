using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class Bomb : MonoBehaviour
    {
        private Rigidbody2D _rigidBody;
        public float xAxis;
        public float yAxis;

        void Start()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
            _rigidBody.AddForce(new Vector2(xAxis, yAxis), ForceMode2D.Impulse);
            Destroy(gameObject, 3f);
        }
    }
}