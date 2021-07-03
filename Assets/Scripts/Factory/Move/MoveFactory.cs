using UnityEngine;
using Assembly_CSharp.Assets.Scripts.Application;
using Assembly_CSharp.Assets.Scripts.Models;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public class MoveFactory
    {
        private MoveRight _moveRight;
        private MoveJump _moveJump;
        private MoveShoot _moveShoot;

        public MoveFactory(Player player)
        {
            _moveJump = new MoveJump(player);
            _moveRight = new MoveRight(player);
            _moveShoot = new MoveShoot(player);
        }

        public void Move(float speed, float jumpForce)
        {
            _moveJump.Move(jumpForce);
            _moveRight.Move(speed);
            _moveShoot.Move();
        }

        public void OnCollisionEnter(Collision2D collision)
        {
            _moveJump.OnCollisionEnter(collision);
        }
    }
}
