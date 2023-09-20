using System;
using System.Collections.Generic;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyArmy : MonoBehaviour
    {
        [SerializeField] private int rows;
        [SerializeField] private int cols;
        [field: SerializeField] public List<Enemy> Enemies { get; private set; }
        [SerializeField] private float speedEnemy;
        
        private void Update()
        {
            foreach (Enemy e in Enemies)
            {
                if (e == null)
                {
                    Enemies.Remove(e);
                }
            }
            Moving();
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
