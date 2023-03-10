using UnityEngine;

public class Jumpable : MonoBehaviour
{
    [SerializeField] protected float _jumpForce = 8f;
    
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() && collision.relativeVelocity.y < 0) 
        {
            collision.gameObject.GetComponent<Player>().Jump(_jumpForce);
        }
    }
}
