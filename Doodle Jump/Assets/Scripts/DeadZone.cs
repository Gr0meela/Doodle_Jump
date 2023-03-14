using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public bool IsAlive { get; private set; } = true;
    private SaveDataController _data;
    private void Start()
    {
        _data = FindObjectOfType<SaveDataController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Jumpable>())
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            Debug.Log("Ты проиграл");
            IsAlive = false;
            _data.SaveField();
        }
    }
}
