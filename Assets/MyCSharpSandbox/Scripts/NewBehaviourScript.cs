using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.MyCSharpSandbox.Scripts
{
    public class NewBehaviourScript : MonoBehaviour
    {

        private void Start()
        {
            Calculator.IntToInt addOne = Calculator.AddOne;
        }
    }

    public class Calculator
    {
        public delegate int IntToInt(int value);

        public static int AddOne(int value)
        {
            return value + 1;
        }

        public static int GetLength(string value)
        {
            return value.Length;
        }
    }
}