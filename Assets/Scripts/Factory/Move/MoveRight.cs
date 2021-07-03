using Assembly_CSharp.Assets.Scripts.Models;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public class MoveRight : MoveBase
    {

        public MoveRight(Player player) : base(player)
        {
        }

        public override void Move(float speed)
        {
            Rigidbody.velocity = new Vector2(speed, Rigidbody.velocity.y);
        }
    }
}
