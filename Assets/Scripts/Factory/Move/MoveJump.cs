using UnityEngine;
using Assembly_CSharp.Assets.Scripts.Helpers;
using Assembly_CSharp.Assets.Scripts.Application;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public class MoveJump : MoveBase
    {
        private bool isJumping = false;

        public MoveJump(Player player) : base(player)
        {
        }

        public override void Move(float forceJump)
        {
            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                isJumping = true;
                Animator.SetBool(AnimatorHelpers.JUMPING, true);
                Rigidbody.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
            }
        }

        public override void OnCollisionEnter(Collision2D collision)
        {
            if (collision.gameObject.tag == TagHelpers.PLATFORM)
            {
                isJumping = false;
                Animator.SetBool(AnimatorHelpers.JUMPING, false);
            }
        }
    }
}
