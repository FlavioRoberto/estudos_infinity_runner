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
            _time += Time.deltaTime;

            if (_time >= SpawnTime)
            {
                Spawn();
                _time = 0;
            }
        }

        private void Spawn()
        {
            var positionY = transform.position + new Vector3(0, Random.Range(-2, 2));
            Instantiate(enemies[0], positionY, transform.rotation);
        }
    }
}
