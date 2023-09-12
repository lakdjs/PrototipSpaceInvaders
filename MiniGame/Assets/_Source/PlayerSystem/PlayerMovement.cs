using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement 
    {
        public void Move(Rigidbody rb, float speed, Vector3 moveDir)
        {
            Vector3 velocity = moveDir * speed;
            rb.velocity = new Vector3(velocity.x, 0, 0);
        }
    }
}
