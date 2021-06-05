using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public class MoveFactory
    {
        private MoveRight _moveRight;
        private MoveJump _moveJump;

        public MoveFactory(Player player)
        {
            _moveRight = new MoveRight(player);
            _moveJump = new MoveJump(player);
        }

        public void Move(float speed, float jumpForce)
        {
            _moveRight.Move(speed);
            _moveJump.Move(jumpForce);
        }

        public void OnCollisionEnter(Collision2D collision)
        {
            _moveRight.OnCollisionEnter(collision);
            _moveJump.OnCollisionEnter(collision);
        }
    }
}
