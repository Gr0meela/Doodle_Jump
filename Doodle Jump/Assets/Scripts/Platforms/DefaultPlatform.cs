using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultPlatform : Jumpable
{
    protected float _startPoint;
    public virtual void Start()
    {
        _startPoint = Random.Range(-2f, 2f);
    }
}
