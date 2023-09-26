using System;
using UnityEngine;

namespace EnemySystem
{
    public class Enemy : MonoBehaviour
    {
        [field: SerializeField] public Rigidbody Rb { get; private set; }
        
        [SerializeField] private LayerMask layer;
        private EnemyArmy _enemyArmy;

        private void Start()
        {
            //Rb = GetComponent<Rigidbody>();
        }
        public void Initialize(EnemyArmy enemyArmy)
        {
            _enemyArmy = enemyArmy;
        }
        public void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.layer == 6)
            {
                Destroy(gameObject);
            }
        }
    }
}
