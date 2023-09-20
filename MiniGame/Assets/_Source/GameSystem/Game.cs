using System;
using EnemySystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameSystem
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private EnemyArmy army;
        private void Update()
        {
            Win();
        }

        public void Lose()
        {
            Debug.Log("Lose");
        }

        void Win()
        {
           if (army.Enemies.Count == 0)
           {
            Debug.Log("win");
           }
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
