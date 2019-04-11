using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.MyCSharpSandbox.Scripts
{
    public class NewBehaviourScript : MonoBehaviour
    {

        private void Start()
        {
            Func<int, int, int> func = (int i, int i1) => { return i + i1;};
            
            Debug.Log(func(1,2));
        }

        static int Calc(int hoge, int fuga)
        {
            return hoge + fuga;
        }
    }

    
}