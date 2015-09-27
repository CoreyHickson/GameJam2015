using UnityEngine;

public class player2 : player
{
    public override bool getPlayerKeyDown()
    {
        return Input.GetKeyDown("f");
    }

    public override void resetPosition()
    {
        hand.position = new Vector2(8.89f, 3.96f);
        onStack = false;
    }
}
