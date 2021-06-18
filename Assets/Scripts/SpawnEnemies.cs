using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts
{
    public class SpawnEnemies : MonoBehaviour
    {
        public List<GameObject> enemies = new List<GameObject>();
        public float SpawnTime;
        private float _time;

        void Start()
        {
        }

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

        private void Create()
        {
            var enemyIndex = Random.Range(0, enemies.Count);
            var positionY = transform.position + new Vector3(0, Random.Range(-2, 2), 0);
            Instantiate(enemies[enemyIndex], positionY, transform.rotation);
        }
    }
}
