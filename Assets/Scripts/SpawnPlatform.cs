using System.Collections.Generic;
using Assembly_CSharp.Assets.Scripts.Helpers;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts
{
    public class SpawnPlatform : MonoBehaviour
    {
        public List<GameObject> Platforms;
        private readonly float DISTANCE = 30;
        private List<Transform> _platformsInstance;
        private Transform _playerTransform;
        private Transform _currentPlatformPoint;
        private int _currentPlatformIndex;
        private float _offset;

        public SpawnPlatform()
        {
            Platforms = new List<GameObject>();
            _platformsInstance = new List<Transform>();
        }

        void Start()
        {
            _playerTransform = GameObject.FindGameObjectWithTag(TagHelpers.PLAYER).transform;

            GeneratePlatforms();

            DefinePlatformFinalPoint();
        }

        void Update()
        {
            Move();
        }

        private void Move()
        {
            var distanceAtFinalPoint = _playerTransform.position.x - _currentPlatformPoint.position.x;

            if (distanceAtFinalPoint >= 1)
            {
                Recycle(_platformsInstance[_currentPlatformIndex].gameObject);

                _currentPlatformIndex++;

                if (_currentPlatformIndex > _platformsInstance.Count - 1)
                    _currentPlatformIndex = 0;

                DefinePlatformFinalPoint();
            }
        }

        private void GeneratePlatforms()
        {
            for (var i = 0; i < Platforms.Count; i++)
            {
                var currentPlatform = Instantiate(Platforms[i], new Vector2(i * DISTANCE, -4f), transform.rotation);
                _platformsInstance.Add(currentPlatform.transform);
                _offset += DISTANCE;
            }
        }

        private void DefinePlatformFinalPoint()
        {
            _currentPlatformPoint = _platformsInstance[_currentPlatformIndex].GetComponent<Platform>().FinalPoint;
        }

        private void Recycle(GameObject platform)
        {
            platform.transform.position = new Vector2(_offset, -4);
            _offset += DISTANCE;
        }
    }
}
