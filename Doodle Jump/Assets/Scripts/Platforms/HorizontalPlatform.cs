using UnityEngine;

public class HorizontalPlatform : DefaultPlatform
{
    private float _length;
    [SerializeField] private float _speed = 5f;
    private float _time = 0f;
    private float _offset;
    public override void Start()
    {
        _startPoint = Random.Range(-2f, 0f);
        _length = Random.Range(0.7f, 1.2f);
        transform.position = new Vector3(_startPoint, transform.position.y);
        _offset = Random.Range(0, 2* Mathf.PI);
    }
    void Update()
    {
        _time += Time.deltaTime;
        transform.position = new Vector3(_startPoint + (Mathf.Sin(_time * _speed + _offset) + 1f) * _length, transform.position.y);
    }
}
