using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public void DisableCollision()
    {
        GetComponentInParent<Collider2D>().enabled = false;
    }
}
