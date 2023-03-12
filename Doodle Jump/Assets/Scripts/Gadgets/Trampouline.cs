using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampouline : Spring
{
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() && collision.relativeVelocity.y < 0)
        {
            collision.gameObject.GetComponent<Player>().Jump(_jumpForce);
            collision.gameObject.GetComponent<Animator>().SetTrigger("IsFlip");
            _animator.SetTrigger("Jump");
        }
    }
}
