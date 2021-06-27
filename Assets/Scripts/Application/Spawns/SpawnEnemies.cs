using System.Collections.Generic;
using Assembly_CSharp.Assets.Scripts.Application.Spawns.Base;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application.Spawns
{
    public class SpawnEnemies : SpawnEnemiesBase
    {
        public float SpawnTime;
        private float _time;

        void Update()
        {
            Spawn();
        }

        private void Spawn()
        {
            _time += Time.deltaTime;

            if (_time >= SpawnTime)
            {
                Create();
                _time = 0;
            }
        }

        protected override void InstantiateEnemy(GameObject enemy)
        {
            var enemyIndex = Random.Range(0, enemies.Count);
            var positionY = transform.position + new Vector3(0, Random.Range(-2, 2), 0);
            Instantiate(enemies[enemyIndex], positionY, transform.rotation);
        }

    }
}
