using System;

namespace Assembly_CSharp.Assets.Scripts.Models
{
    public class Enemy
    {
        public int Health { get; private set; }
        public int Damage { get; private set; }

        public Enemy(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public virtual void ApplyDamage(int damage, Action destroy)
        {
            Health -= damage;

            if (Health <= 0)
                destroy();
        }
    }
}
