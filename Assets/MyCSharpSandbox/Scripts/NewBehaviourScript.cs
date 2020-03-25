using UnityEngine;

namespace MyCSharpSandbox.Scripts
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private delegate void SomeDelegate(int a);

        private void Start()
        {
            SomeDelegate
                a = delegate(int i) { Debug.Log($"A({i})が呼ばれました"); };
                a += i => Debug.Log($"B({i})が呼ばれました");

            a(256);

            Increments();
        }

        private static void A(int hoge)
        {
            Debug.Log($"A({hoge})が呼ばれました");
        }

        private static void B(int fuga)
        {
            Debug.Log($"B({fuga})が呼ばれました");
        }

        private static void Increments()
        {
            var num = 0;
            if (num++ == 0)
            {
                // ここが呼ばれるにもかかわらずnumは１になる。つまり, ==0後に加算されている
                Debug.Log("変数numは0");
            }
            else
            {
                Debug.Log("変数numは!0");
            }
            Debug.Log("変数numは"+num);
        }
    }
}