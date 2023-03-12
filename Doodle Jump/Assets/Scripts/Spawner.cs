using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _eventPlatforms;
    [SerializeField] private PlatformSamples[] _platformSamples;
    private Vector3 _cameraBorders;
    private Transform _player;
    [SerializeField] private float _spawnBorder;
    private float _spawnStep = 10f;

    private float _minPlatformDistance = 0.3f;
    private float _maxPlatformDistance = 1f;
    private float _platformStep = 0.1f;
    private float _criticalPlatformDistance = 3f;
    private float _counter;
    void Start()
    {
        _player = FindObjectOfType<Player>().transform;
        Camera camera = Camera.main;
        _cameraBorders = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane));
        _spawnBorder = _cameraBorders.y * 2f;
        _counter = _player.position.y;
        SpawnSample(_platformSamples[0]);
    }

    void Update()
    {
        if(_player.position.y >= _spawnBorder / 2f)
        {
            _spawnBorder += _spawnStep;
            SpawnSample(_platformSamples[SetSampleIndex()]);
            if(_maxPlatformDistance < _criticalPlatformDistance)
            {
                _minPlatformDistance += _platformStep;
                _maxPlatformDistance += _platformStep;
                _spawnStep += 10 * _platformStep;
            }
        }
    }
    void SpawnSample(PlatformSamples sample)
    {
        while (_counter < _spawnBorder)
        {
            _counter += Random.Range(_minPlatformDistance, _maxPlatformDistance);
            //Instantiate(_platforms[0], new Vector2(transform.position.x, _counter), Quaternion.identity);

            int index = Random.Range(0, sample.Platforms.Length);
            Instantiate(sample.Platforms[index], new Vector2(transform.position.x, _counter), Quaternion.identity);
        }
    }
    void SpawnEventPlatform()
    {

    }
    int SetSampleIndex()
    {
        /*
        if (_spawnBorder >= 50)
        {
            int index = Random.Range(0, _platformSamples.Length - 1);
            return index;
        }
        else if (_spawnBorder >=  1000)
        {
            int index = Random.Range(0, _platformSamples.Length);
            return index;
        }
        else return 0;*/
        Debug.Log(Mathf.Clamp((int)_spawnStep/5, 0, _platformSamples.Length));
        int index = Random.Range(0, Mathf.Clamp((int)_spawnStep/5, 0, _platformSamples.Length));
        return index;
    }
}
