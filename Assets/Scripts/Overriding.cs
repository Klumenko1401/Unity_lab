using UnityEngine;
using System.Collections;

public class Player1
{
    public string Name;

    public Player1()
    {
        Name = "Jack";
        Debug.Log("1st Player Constructor Called");
    }

    public virtual void Movement()
    {
        Debug.Log("The player is moving.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a player.");
    }
}

public class Watcher1 : Player1
{
    public Watcher1
()
    {
        Debug.Log("1st Watcher Constructor Called");
    }

    public override void Movement()
    {
        base.Movement();
        Debug.Log("The watcher is moving.");
    }

    public void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am a watcher.");
    }
}

public class Interaction1 : MonoBehaviour
{
    void Start()
    {
        Watcher1 myWatcher = new Watcher1();

        myWatcher.SayHello();
        myWatcher.Movement();

            
        Player1 myPlayer = new Watcher1();

        myPlayer.SayHello();
        myPlayer.Movement();

    }
}