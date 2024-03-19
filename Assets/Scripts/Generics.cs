using UnityEngine;
using System.Collections;

public class SomeClass
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();

        myClass.GenericMethod<char>('k');
    }
}
public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass<char> myClass = new GenericClass<char>();

        myClass.UpdateItem('k');
    }
}
