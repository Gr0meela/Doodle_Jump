using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : Jumpable
{
    protected Animator _animator;
    protected void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() && collision.relativeVelocity.y < 0)
        {
            collision.gameObject.GetComponent<Player>().Jump(_jumpForce);
            _animator.SetTrigger("Jump");
        }
    }
}