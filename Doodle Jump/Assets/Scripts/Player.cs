using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody;
    private SpriteRenderer _renderer;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _startForce = 5f;
    //���� ��� ������ �� ��
    [Range(-1f, 1f)] public float horizontal = 0f;
    private bool _isRotating = true;
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _renderer = GetComponentInChildren<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        _playerRigidbody.velocity = new Vector2(_playerRigidbody.velocity.x, _startForce);
    }
    void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        //float horizontal = Input.acceleration.x;
        _playerRigidbody.velocity = new Vector2(horizontal * _speed, _playerRigidbody.velocity.y);
        if (_isRotating)
            Rotate();
    }
    public void Jump(float jumpPower)
    {
        _playerRigidbody.velocity = new Vector2(_playerRigidbody.velocity.x, jumpPower);
    }
    public void DoaFlip()
    {
        _animator.SetTrigger("IsFlip");
    }
    private void Rotate()
    {
        if (horizontal < 0)
        {
            _renderer.flipX = false;
        }
        else if (horizontal > 0)
        {
            _renderer.flipX = true;
        }
    }
    public void SetRotation()
    {
        _isRotating = !_isRotating;
    }
}
