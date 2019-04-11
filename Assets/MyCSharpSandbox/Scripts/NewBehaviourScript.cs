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
            var list = new List<string>();
            
            list.Add("hoge");

            var result = list.Select(s => s + ".txt" );
            
        }

        private static string Append(string s)
        {
            return s + ".txt";
        }
    }

    
}