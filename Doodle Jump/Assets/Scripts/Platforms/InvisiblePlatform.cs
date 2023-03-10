using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisiblePlatform : DefaultPlatform
{
    private Animator _animator;
    private Player _player;
    public override void Start()
    {
        _animator = GetComponent<Animator>();
        _player = FindObjectOfType<Player>();
    }
    void Update()
    {
        if (_player.transform.position.y >= transform.position.y)
            _animator.SetBool("IsShowing", true);
        else
            _animator.SetBool("IsShowing", false);
    }
}
