using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assembly_CSharp.Assets.Scripts.Controller
{
    public class GameController : MonoBehaviour
    {
        public static GameController instance;
        public GameObject gameOverPanel;

        void Start()
        {
            instance = this;
            Time.timeScale = 1;
        }

        public void ShowGameOver()
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }

        public void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }
}
