using UnityEngine;

public class ScreenBordersTeleport : MonoBehaviour
{
    private Vector3 _cameraBorders;
    void Start()
    {
        Camera camera = Camera.main;
        _cameraBorders = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane));
    }

    void Update()
    {
        if(transform.position.x > _cameraBorders.x)
        {
            transform.position = new Vector2(- _cameraBorders.x, transform.position.y);
        }
        else if (transform.position.x < -_cameraBorders.x)
        {
            transform.position = new Vector2(_cameraBorders.x, transform.position.y);
        }
    }
}
