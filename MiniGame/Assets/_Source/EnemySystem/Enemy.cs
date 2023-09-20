using System;
using UnityEditor.UIElements;
using UnityEngine;

namespace EnemySystem
{
    public class Enemy : MonoBehaviour
    {
        [field: SerializeField] public float HealthEnemy { get; private set; }
        [field: SerializeField] public Rigidbody Rb { get; private set; }
        
        [SerializeField] private LayerMask layer;

        private void Start()
        {
            //Rb = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.layer == 6)
            {
                Destroy(gameObject);
            }
        }
    }
}
