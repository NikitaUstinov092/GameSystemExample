using GameSystem.Scripts.GameSystem;
using Sirenix.OdinInspector;
using UnityEngine;



public class DO : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;
    
    [Button]
    private void Action()
    {
        if(_gameObject.TryGetComponent(out IExample example))
        {
            example.Example();
        }
        else
        {
            Debug.Log("Не найден");
        }
    }
}











