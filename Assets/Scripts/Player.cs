using Assembly_CSharp.Assets.Scripts.Factory.Move;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public float Speed;
        public float ForceJump;
        public Animator Animator;
        private MoveFactory _moveFactory;

        void Start()
        {
            _moveFactory = new MoveFactory(this);
        }

        void FixedUpdate()
        {
            _moveFactory.Move(Speed, ForceJump);
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            _moveFactory.OnCollisionEnter(collision);
        }

    }
}
