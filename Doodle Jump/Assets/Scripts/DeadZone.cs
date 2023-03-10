using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Player>())
        {
            Debug.Log("�� ��������");
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
