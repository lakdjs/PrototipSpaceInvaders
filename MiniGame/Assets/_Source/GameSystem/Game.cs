using System;
using EnemySystem;
using ScoreSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameSystem
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private EnemyArmy army;
        [SerializeField] private ScoreView scoreView;
        [SerializeField] private Panel endingPanel;
        [SerializeField] private string win;
        [SerializeField] private string lose;
        private Score _score;

        private void Start()
        {
           _score = new Score(scoreView);
        }

        private void FixedUpdate()
        {
            Win();
        }

        public void Lose()
        {
            Time.timeScale = 0;
            endingPanel.Ending(lose);
        }

        void Win()
        {
           if (army.Enemies.Count == 0)
           { 
            Time.timeScale = 0;
            endingPanel.Ending(win);
           }
        }

        public void Restart()
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
