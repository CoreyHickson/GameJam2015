using UnityEngine;

public class player1 : player
{
    public override bool getPlayerKeyDown()
    {
        return Input.GetKeyDown("a");
    }

    public override void resetPosition()
    {
        hand.position = new Vector2(-9.220002f, 3.690001f);
        onStack = false;
    }
}
