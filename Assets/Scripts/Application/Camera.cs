using Assembly_CSharp.Assets.Scripts.Helpers;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class Camera : MonoBehaviour
    {
        public float TransitionSpeed;
        public float Offset = 0;
        private Transform player;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag(TagHelpers.PLAYER).transform;
        }

        private void LateUpdate()
        {
            var camPosition = new Vector3(player.position.x + Offset, 0, transform.position.z);
            transform.position = Vector3.Slerp(transform.position, camPosition, TransitionSpeed * Time.deltaTime);
        }
    }
}
