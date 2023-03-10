using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : DefaultPlatform
{
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() && collision.relativeVelocity.y < 0)
        {
            collision.gameObject.GetComponent<Player>().Jump(_jumpForce);
            Destroy(gameObject);
        }
    }
}
