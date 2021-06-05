using UnityEngine;
using Assembly_CSharp.Assets.Scripts.Helpers;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public class MoveJump : MoveBase
    {
        private bool isJumping;

        public MoveJump(Player player) : base(player)
        {
            isJumping = false;
        }

        public void Move(float forceJump)
        {
            if (!Input.GetKeyDown(KeyCode.Space) || isJumping)
                return;

            isJumping = true;
            GetAnimator().SetBool(AnimatorHelpers.JUMPING, true);
            GetRigidbody().AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
        }

        public override void OnCollisionEnter(Collision2D collision)
        {
            if (collision.gameObject.tag == TagHelpers.PLATFORM)
            {
                isJumping = false;
                GetAnimator().SetBool(AnimatorHelpers.JUMPING, false);
            }
        }
    }
}
