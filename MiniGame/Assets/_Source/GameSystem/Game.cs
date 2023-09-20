using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameSystem
{
    public class Game : MonoBehaviour
    {
        private void Update()
        {
            
        }

        void Lose()
        {
            
        }

        void Win()
        {
            
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
