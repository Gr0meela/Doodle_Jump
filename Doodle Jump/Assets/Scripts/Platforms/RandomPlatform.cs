using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlatform : DefaultPlatform
{
    private float _length;
    private bool _isFinished = false;
    public override void Start()
    {
        base.Start();
        StartCoroutine("SetPosition");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(_length, transform.position.y), Time.deltaTime);
        if (transform.position == Vector3.MoveTowards(transform.position, new Vector2(_length, transform.position.y), Time.deltaTime))
            _isFinished = true;
        else
            _isFinished = false;
    }
    IEnumerator SetPosition()
    {
        _length = Random.Range(-2f, 2f);
        yield return new WaitUntil(()=>_isFinished);
        StartCoroutine("SetPosition");
    }
}
