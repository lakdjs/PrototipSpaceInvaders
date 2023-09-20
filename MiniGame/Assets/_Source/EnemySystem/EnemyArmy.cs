using System;
using System.Collections.Generic;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyArmy : MonoBehaviour
    {
        [SerializeField] private int rows;
        [SerializeField] private int cols;
        [SerializeField] private List<Enemy> enemies;
        [SerializeField] private float speedEnemy;
        
        private void Update()
        {
            Moving();
        }

        void Moving()
        {
            foreach (Enemy e in enemies)
            {
                if (e.Rb != null)
                {
                    e.Rb.velocity = new Vector3(0, -speedEnemy, 0);
                }
            }
        } 
    }
}
