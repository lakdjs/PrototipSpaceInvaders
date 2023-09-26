using System;
using System.Collections.Generic;
using ScoreSystem;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyArmy : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private int rows;
        [SerializeField] private int cols;
        [SerializeField] private float step;
        [SerializeField] private ScoreView scoreView;
        [field: SerializeField] public List<Enemy> Enemies { get; private set; }
        [SerializeField] private float speedEnemy;
        private Score _score;

        private void Start()
        {
            foreach (Enemy e in Enemies)
            {
                e.Initialize(this);
            }
            _score = new Score(scoreView);
        }

        private void Update()
        {
            Moving();
        }

        private void FixedUpdate()
        {
            Killing();
        }

        public void Killing()
        {
            foreach (Enemy e in Enemies)
            {
                if (e == null)
                {
                    Enemies.Remove(e);
                    _score.ScoreGain();
                }
            }
        }
        void Moving()
        {
            foreach (Enemy e in Enemies)
            {
                if (e.Rb != null)
                {
                    e.Rb.velocity = new Vector3(0, -speedEnemy, 0);
                }
            }
        }
    }
}
