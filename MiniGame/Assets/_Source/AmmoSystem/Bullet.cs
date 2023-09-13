using System;
using UnityEngine;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float destroyTime;
        private Rigidbody _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.useGravity = false;
            Destroy(gameObject, destroyTime);
        }
        private void Update()
        {
            Fly();
        }

        void Fly()
        {
            _rb.velocity = transform.up * speed;
        }
        
        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    }
}
