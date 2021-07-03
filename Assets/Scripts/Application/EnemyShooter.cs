using Assembly_CSharp.Assets.Scripts.Application.Base;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class EnemyShooter : EnemyApplication
    {
        public GameObject Projectile;
        public Transform FirePoint;
        public float ThrowTime;
        private float _throwCount;

        void Update()
        {
            _throwCount += Time.deltaTime;

            if (_throwCount >= ThrowTime)
            {
                Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
                _throwCount = 0;
            }
        }
    }
}