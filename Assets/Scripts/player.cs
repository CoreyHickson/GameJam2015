using UnityEngine;
using System.Collections;
using System;

public abstract class player : MonoBehaviour
{
    public initialization clock;
    public Rigidbody2D hand;
    public bool onStack;

    // Use this for initialization
    public void Start()
    {
        hand = GetComponent<Rigidbody2D>();
        onStack = false;
    }

    // Update is called once per frame
    public void Update()
    {
        // This is for a keyboard set-up
        // Use a GetButtonDown with the appropriate buttons for otherwise
        if (clock.isRinging && getPlayerKeyDown() && !onStack)
        {
            hand.position = new Vector2(0, 0);
            onStack = true;
            clock.positions.Push(this);
        }
    }

    public void removePlayer()
    {
        gameObject.SetActive(false);
    }

    // This is abstract so that I can have a bunch of players which extend this
    // Saving me from having to do 4x the code! Haza!
    abstract public bool getPlayerKeyDown();

    abstract public void resetPosition();
}