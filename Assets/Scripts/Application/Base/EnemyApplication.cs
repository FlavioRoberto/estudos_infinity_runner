using Assembly_CSharp.Assets.Scripts.Helpers;
using Assembly_CSharp.Assets.Scripts.Models;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application.Base
{
    public abstract class EnemyApplication : DamageBehaviour
    {
        public int Health;
        protected Enemy _enemy;
        protected virtual void Start()
        {
            _enemy = new Enemy(Health, damage);
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            var coliderGameObject = collider.gameObject;

            if (coliderGameObject.tag == TagHelpers.PROJECTILLE)
            {
                var projectille = coliderGameObject.GetComponent<Projectile>();
                _enemy.ApplyDamage(projectille.Damage, () => Destroy(gameObject));
            }
        }
    }
}
