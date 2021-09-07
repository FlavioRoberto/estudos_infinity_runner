using UnityEngine;
using Assembly_CSharp.Assets.Scripts.Application;
using Assembly_CSharp.Assets.Scripts.Models;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public abstract class MoveBase : MonoBehaviour
    {
        private Player _player;
        public abstract void Move(float velocity = 0);

        public MoveBase(Player player)
        {
            _player = player;
        }

        protected Rigidbody2D Rigidbody
        {
            get { return _player.Rigidbody2D; }
        }

        protected Animator Animator
        {
            get { return _player.Animator; }
        }

        protected Transform FirePoint
        {
            get { return _player.FirePoint; }
        }

        protected Projectile Projectille
        {
            get { return _player.Projectille; }
        }

        protected float ReloadTime
        {
            get { return _player.ReloadTime; }
        }

        public virtual void CollisionEnter(Collision2D collision)
        {
        }
    }
}
