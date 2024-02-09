using UnityEngine;

namespace GameSystem.Scripts.GameSystem
{
    public class Test2 : TestAbstract
    {
        public override void Method()
        {
            throw new System.NotImplementedException();
        }

        public override void Method2()
        {
           Debug.Log("Test2 логика");
           base.Method2();
        }
    }
}