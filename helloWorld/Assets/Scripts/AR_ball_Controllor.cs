using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_ball_Controllor : DefaultTrackableEventHandler
{
    public Rigidbody player;

    override protected void OnTrackingLost()
    {
        player.useGravity = false;
    }
    override protected void OnTrackingFound()
    {
        player.useGravity = true;
    }
}
