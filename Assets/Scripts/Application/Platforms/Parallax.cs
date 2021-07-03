using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application.Platforms
{
    public class Parallax : MonoBehaviour
    {
        private float _width;
        private float _startPosition;
        public Transform Camera;
        public float ParalaxSpeed;

        private void Start()
        {
            _startPosition = transform.position.x;
            _width = GetComponent<SpriteRenderer>().bounds.size.x;
        }

        private void LateUpdate()
        {
            var reposition = Camera.transform.position.x * (1 - ParalaxSpeed);
            var distance = Camera.transform.position.x * ParalaxSpeed;
            transform.position = new Vector3(_startPosition + distance, transform.position.y, transform.position.z);

            if (reposition > _startPosition + _width)
                _startPosition += _width;

        }

    }
}
