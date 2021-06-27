using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application.Spawns.Base
{
    public abstract class SpawnEnemiesBase : MonoBehaviour
    {
        public List<GameObject> enemies = new List<GameObject>();
        protected abstract void InstantiateEnemy(GameObject enemy);

        protected void Create()
        {
            var enemyIndex = Random.Range(0, enemies.Count);
            InstantiateEnemy(enemies[enemyIndex]);
        }
    }
}
