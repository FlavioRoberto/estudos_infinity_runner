using Assembly_CSharp.Assets.Scripts.Application.Base;
using Assembly_CSharp.Assets.Scripts.Controller;
using Assembly_CSharp.Assets.Scripts.Factory.Move;
using Assembly_CSharp.Assets.Scripts.Models;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class PlayerApplication : MonoBehaviour
    {
        public Animator Animator;
        public Projectile Projectille;
        public Transform FirePoint;
        public float Speed = 5;
        public float ForceJump = 10;
        public float ReloadTime = 2;
        public int Health = 3;
        private Player _player;
        private MoveFactory _moveFactory;

        void Start()
        {
            _player = new Player(Animator, Projectille, FirePoint, GetComponent<Rigidbody2D>(), Health, Speed, ForceJump, ReloadTime);
            _moveFactory = new MoveFactory(_player);
        }

        void Update()
        {
            _moveFactory.Move(Speed, ForceJump);
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            _moveFactory.CollisionEnter(collision);
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            ApplyDamage(collider);
        }

        public void OnJump()
        {
            _moveFactory.Jump(ForceJump);
        }

        public void OnShoot()
        {
            _moveFactory.Shoot();
        }

        private void OnHit(int damage)
        {
            _player.Hit(damage);

            if (_player.IsDead())
                GameController.instance.ShowGameOver();
        }

        private void ApplyDamage(Collider2D collider)
        {
            var damageComponent = collider.GetComponent<DamageBehaviour>();

            if (damageComponent != null)
                OnHit(damageComponent.damage);
        }
    }
}
