using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public abstract class MoveBase
    {
        private Player _player;

        public MoveBase(Player player)
        {
            _player = player;
        }

        protected Rigidbody2D GetRigidbody()
        {
            return _player.GetComponent<Rigidbody2D>();
        }

        protected Animator GetAnimator()
        {
            return _player.Animator;
        }

        public virtual void OnCollisionEnter(Collision2D collision)
        {
        }
    }
}
