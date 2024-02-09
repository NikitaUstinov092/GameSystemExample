using UnityEngine;

namespace GameSystem.Scripts.GameSystem
{
    public abstract class TestAbstract: MonoBehaviour
    {
        public abstract void Method();

        public virtual void Method2()
        {
            Debug.Log("Базовая логика");
        }
    }
}