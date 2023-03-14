using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _playerPosition;
    [SerializeField] private float _cameraSpeed = 5f;
    private DeadZone _deadZone;
    private Vector3 _cameraBorders;
    private Vector3 _highestPos;
    private void Start()
    {
        Camera camera = Camera.main;
        _cameraBorders = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane));

        _deadZone = FindObjectOfType<DeadZone>();
    }
    void Update()
    {
        if (_deadZone.IsAlive)
        {
            AddScorePoint();
            PlayerFollow();
        }
        else
            LoseScreen();
    }
    private void PlayerFollow()
    {
        if (_playerPosition.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, _playerPosition.position.y, transform.position.z);
            _highestPos = transform.position;
        }
    }
    private void LoseScreen()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, _highestPos.y - _cameraBorders.y, transform.position.z), Time.deltaTime * _cameraSpeed);
    }
    private void AddScorePoint()
    {
        if (_playerPosition.position.y > transform.position.y)
        {
            _player.Score++;
        }
    }
}
