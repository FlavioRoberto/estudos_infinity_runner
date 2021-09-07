using Assembly_CSharp.Assets.Scripts.Controller;
using Assembly_CSharp.Assets.Scripts.Helpers;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class GameOver : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(TagHelpers.PLAYER))
                GameController.instance.ShowGameOver();
        }
    }
}
