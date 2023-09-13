using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker 
    {
        private PlayerMovement _playerMovement;
        private PlayerShooting _playerShooting;
        private Player _player;
        public PlayerInvoker(Player player)
        {
            _player = player;
            _playerMovement = new PlayerMovement();
            _playerShooting = new PlayerShooting();
        }
        public void Move(Vector3 moveDirection)
        {
            _playerMovement.Move(_player.Rb,_player.MovementSpeed,moveDirection);
        }

        public void Shoot()
        {
            _playerShooting.Shoot(_player.FirePoint, _player.BulletPrefab);
        }
        
    }
}
