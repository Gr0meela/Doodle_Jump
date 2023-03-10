using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody;
    private SpriteRenderer _renderer;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed = 5f;
    [Range(-1f, 1f)] public float horizontal = 0f;
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _renderer = GetComponentInChildren<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        //float horizontal = Input.acceleration.x;
        if(horizontal < 0)
        {
            _renderer.flipX = false;
        }
        else if (horizontal > 0)
        {
            _renderer.flipX = true;
        }
        _playerRigidbody.velocity = new Vector2(horizontal * _speed, _playerRigidbody.velocity.y);
    }
    public void Jump(float jumpPower)
    {
        _playerRigidbody.velocity = new Vector2(_playerRigidbody.velocity.x, jumpPower);
    }
    public void DoaFlip()
    {
        _animator.SetTrigger("IsFlip");
    }
}
