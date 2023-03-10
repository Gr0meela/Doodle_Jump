using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenPlatform : DefaultPlatform
{
    private Animator _animator;
    public override void Start()
    {
        base.Start();
        _animator = GetComponentInChildren<Animator>();
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() && collision.relativeVelocity.y < 0)
        {
            _animator.SetTrigger("Break");
        }
    }
}
