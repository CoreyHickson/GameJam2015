using UnityEngine;

public class player4 : player
{
    public override bool getPlayerKeyDown()
    {
        return Input.GetKeyDown("l");
    }

    public override void resetPosition()
    {
        hand.position = new Vector2(8.97f, -3.61f);
        onStack = false;
    }
}
