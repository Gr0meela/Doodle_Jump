using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreenUI : MonoBehaviour
{
    private DeadZone _deadZone;
    [SerializeField] private GameObject _canvasPoint;
    void Start()
    {
        _deadZone = FindObjectOfType<DeadZone>();
    }
    void Update()
    {
        if(!_deadZone.IsAlive)
        {
            _canvasPoint.transform.parent = null;
        }
    }
}
