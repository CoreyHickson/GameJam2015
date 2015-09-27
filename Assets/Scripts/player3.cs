using UnityEngine;

public class player3 : player
{
    public override bool getPlayerKeyDown()
    {
        return Input.GetKeyDown("h");
    }

    public override void resetPosition()
    {
        hand.position = new Vector2(-9.09f, -4.09f);
        onStack = false;
    }
}
