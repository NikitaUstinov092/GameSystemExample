using UnityEngine;

namespace GameSystem.Scripts.GameSystem
{
   
        public class Test1 : MonoBehaviour, IExample
        {
            void IExample.Example()
            {
                Debug.Log("Example");
            }
        }

        public interface IExample
        {
            void Example();
        }
    
    }
