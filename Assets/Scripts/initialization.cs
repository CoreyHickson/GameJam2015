using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class initialization : MonoBehaviour {

    private Animator anim;
    public bool isRinging;
    // This stack will contain the players as their hands go onto the alarm clock
    public Stack<player> positions;
    public int round;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        positions = new Stack<player>();
        round = 1;
        isRinging = false;

        StartCoroutine(beginCountdown());
    }

    // Sets the clock ringing after a random time
    IEnumerator beginCountdown()
    {
        float randomSeconds = Random.Range(3.0f, 10.0f);
        yield return new WaitForSeconds(randomSeconds);
        anim.SetBool("ringing", true);
        isRinging = true;
    }

    // Update is called once per frame
    void Update()
    {
        switch (round)
        {
            case 1:
                if(positions.Count == 4)
                {
                    positions.Pop().removePlayer();
                    round++;
                    reset();
                }
                break;
            case 2:
                if(positions.Count == 3)
                {
                    positions.Pop().removePlayer();
                    round++;
                    reset();
                }
                break;
            case 3:
                if(positions.Count == 2)
                {
                    positions.Pop().removePlayer();
                    round++;
                    endGame();
                }
                break;
        }
    }

    // Resets the clock for the next game
    public void reset()
    {
        anim.SetBool("ringing", false);
        while( positions.Count > 0 )
        {
            positions.Pop().resetPosition();
        }

        isRinging = false;
        StartCoroutine(beginCountdown());
    }

    // Finish the game
    public void endGame()
    {
        player winner = positions.Pop();
        winner.resetPosition();
        anim.SetBool("ringing", false);
    }
}