using UnityEngine;
using System.Collections;

public class Player
{
    public string Name;

    public Player()
    {
        Name = "Jack";
        Debug.Log("1st Player Constructor Called");
    }

    public Player(string newName)
    {
        Name = newName;
        Debug.Log("2nd Player Constructor Called");
    }

    public void Movement()
    {
        Debug.Log("The " + Name + " player is moving.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a player.");
    }
}

public class Watcher : Player
{
    public Watcher
()
    {
        Name = "Dack";
        Debug.Log("1st Watcher Constructor Called");
    }

    public Watcher (string newName) : base(newName)
    {
        Debug.Log("2nd Watcher Constructor Called");
    }
}

public class Interaction : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Creating the player");
        Player myPlayer = new Player();
        Debug.Log("Creating the watcher");
        Watcher myWatcher = new Watcher();

        myPlayer.SayHello();
        myPlayer.Movement();

        myWatcher.SayHello();
        myWatcher.Movement();

        Debug.Log("Creating the player");
        myPlayer = new Player("Kate");
        Debug.Log("Creating the watcher");
        myWatcher = new Watcher("Pin");

        myPlayer.SayHello();
        myPlayer.Movement();

        myWatcher.SayHello();
        myWatcher.Movement();
    }
}