using UnityEngine;

namespace PlayerSystem
{
    public class PlayerShooting 
    {
        public void Shoot(Transform firePoint, GameObject bulletPrefab)
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab,firePoint);
        }
    }
}
    
