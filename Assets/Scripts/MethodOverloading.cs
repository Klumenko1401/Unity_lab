using UnityEngine;
using System.Collections;

public class MyClass
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}
public class YourClass : MonoBehaviour
{
    void Start()
    {
        MyClass myClass = new MyClass();

        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }
}