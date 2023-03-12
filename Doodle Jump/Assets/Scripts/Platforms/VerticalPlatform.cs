using UnityEngine;

public class VerticalPlatform : DefaultPlatform
{
    private float _heigth;
    [SerializeField] private float _speed = 5f;
    private float _time = 0f;
    private float _offset;
    private float _yPos;
    public override void Start()
    {
        base.Start();
        _heigth = Random.Range(1.5f, 2.2f);
        _offset = Random.Range(0, 2 * Mathf.PI);
        _yPos = transform.position.y;
    }
    void Update()
    {
        _time += Time.deltaTime;
        transform.position = new Vector3(_startPoint, (Mathf.Sin(_time * _speed + _offset) + 1f) * _heigth + _yPos);
    }
}
