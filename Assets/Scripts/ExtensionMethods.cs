using UnityEngine;
using System.Collections;

public static class ExtensionMethods
{
  
    public static void CustomTransformation(this Transform trans)
    {
        trans.position = new Vector3(2.0f, 3.0f, 4.0f);
        trans.localRotation = Quaternion.Euler(45f, 30f, 15f);
        trans.localScale = new Vector3(2, 2, 2);
    }
}

public class MySomeClass : MonoBehaviour
{
    void Start()
    {
        transform.CustomTransformation();
    }
}