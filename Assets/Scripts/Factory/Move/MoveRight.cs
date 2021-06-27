using Assembly_CSharp.Assets.Scripts.Application;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public class MoveRight : MoveBase
    {

        public MoveRight(Player player) : base(player)
        {
        }

        public void Move(float speed)
        {
            var rigidBody = GetRigidbody();
            rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
        }
    }
}
