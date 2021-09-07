using System;
using Assembly_CSharp.Assets.Scripts.Application;
using Assembly_CSharp.Assets.Scripts.Factory.Move;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Models
{
    public class Player
    {
        public Animator Animator { get; private set; }
        public Projectile Projectille { get; private set; }
        public Transform FirePoint { get; private set; }
        public Rigidbody2D Rigidbody2D { get; private set; }
        public float Speed { get; private set; }
        public float ForceJump { get; private set; }
        public float ReloadTime { get; private set; }
        public int Health { get; private set; }


        public Player(Animator animator, Projectile projectille, Transform firePoint, Rigidbody2D rigidbody2D, int health, float speed, float forceJump, float reloadTime)
        {
            this.Animator = animator;
            this.Projectille = projectille;
            this.FirePoint = firePoint;
            this.Rigidbody2D = rigidbody2D;
            this.Speed = speed;
            this.ForceJump = forceJump;
            this.ReloadTime = reloadTime;
            this.Health = health;
        }

        public bool IsDead()
        {
            return Health <= 0;
        }

        public void Hit(int damage)
        {
            Health -= damage;
        }
    }
}
