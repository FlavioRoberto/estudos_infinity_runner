using Assembly_CSharp.Assets.Scripts.Application;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory.Move
{
    public class MoveShoot : MoveBase
    {        
        private float _timeForReload;

        public MoveShoot(Player player) : base(player)
        {
        }

        public override void Move(float velocity = 0)
        {
            if (Input.GetKeyDown(KeyCode.D) && _timeForReload <= 0){
                _timeForReload = ReloadTime;
                Instantiate(Projectille, FirePoint.position, FirePoint.rotation);
                return;
            }

            _timeForReload -= Time.deltaTime;

        }
    }
}