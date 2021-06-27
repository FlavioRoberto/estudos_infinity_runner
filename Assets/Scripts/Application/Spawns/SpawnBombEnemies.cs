using Assembly_CSharp.Assets.Scripts.Application.Spawns.Base;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application.Spawns
{
    public class SpawnBombEnemies : SpawnEnemiesBase
    {
        public GameObject EnemyPrefab;
        private GameObject _currentEnemy;

        void Start()
        {
            InitializeEventRecycle();
        }

        private void InitializeEventRecycle()
        {
            var platform = GetComponentInParent<Platform>();

            platform.OnRecycleNotify.Then(result =>
            {
                if (_currentEnemy != null)
                    Destroy(_currentEnemy);

                Create();
            });

            Create();
        }

        protected override void InstantiateEnemy(GameObject enemy)
        {
            var transform = enemy.GetComponent<Transform>();
            _currentEnemy = Instantiate(EnemyPrefab, transform.position, transform.rotation);
        }

    }
}
