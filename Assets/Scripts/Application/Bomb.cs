using Assembly_CSharp.Assets.Scripts.Application.Base;
using Assembly_CSharp.Assets.Scripts.Helpers;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class Bomb : DamageBehaviour
    {
        private Rigidbody2D _rigidBody;
        private PlayerApplication _playerApplication;
        public float xAxis;
        public float yAxis;

        void Start()
        {
            _playerApplication = GameObject.FindGameObjectWithTag(TagHelpers.PLAYER).GetComponent<PlayerApplication>();
            _rigidBody = GetComponent<Rigidbody2D>();
            _rigidBody.AddForce(new Vector2(xAxis, yAxis), ForceMode2D.Impulse);
            Destroy(gameObject, 3f);
        }
    }
}