using UnityEngine;
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
            if (Input.GetKeyDown(KeyCode.Space))
                _moveJump.Move(jumpForce);

            if (Input.GetKeyDown(KeyCode.D))
                _moveShoot.Move();

            _moveRight.Move(speed);

        }

        public void Jump(float jumpForce)
        {
            _moveJump.Move(jumpForce);
        }

        public void Shoot()
        {
            _moveShoot.Move();
        }

        public void CollisionEnter(Collision2D collision)
        {
            _moveJump.CollisionEnter(collision);
        }
    }
}
