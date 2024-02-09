using UnityEngine;

namespace GameSystem.Scripts
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 2.5f;
        
        public void Move(Vector3 offset)
        {
            transform.position += offset * _speed;
        }

        public Vector3 GetPosition()
        {
            return transform.position;
        }
    }
}