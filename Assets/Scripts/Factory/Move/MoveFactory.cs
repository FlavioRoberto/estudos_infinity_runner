using UnityEngine;
using Assembly_CSharp.Assets.Scripts.Application;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public class MoveFactory
    {
        private MoveRight _moveRight;
        private MoveJump _moveJump;

        public MoveFactory(Player player)
        {
            _moveJump = new MoveJump(player);
            _moveRight = new MoveRight(player);
        }

        public void Move(float speed, float jumpForce)
        {
            _moveJump.Move(jumpForce);
            _moveRight.Move(speed);
        }

        public void OnCollisionEnter(Collision2D collision)
        {
            _moveJump.OnCollisionEnter(collision);
        }
    }
}
