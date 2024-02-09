using System;
using GameSystem.Scripts.GameSystem;
using UnityEngine;

namespace GameSystem.Scripts
{
    public sealed class CameraFollower : MonoBehaviour, IGameLateUpdateListener
    {
        [SerializeField]
        private Camera _targetCamera;

        [SerializeField]
        private Player _player;

        [SerializeField]
        private Vector3 _offset;

        void IGameLateUpdateListener.OnLateUpdate(float deltaTime)
        {
            _targetCamera.transform.position = _player.GetPosition() + _offset;
        }
    }
}