using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.MyCSharpSandbox.Scripts
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private delegate void SomeDelegate(int a);

        private void Start()
        {
            SomeDelegate 
                a = A;
                a += B;
                
            a(256);
           
        }

        private static void A(int hoge)
        {
            Debug.Log($"A({hoge})が呼ばれました");
        }

        private static void B(int fuga)
        {
            Debug.Log($"B({fuga})が呼ばれました");
        }
    }

    
}