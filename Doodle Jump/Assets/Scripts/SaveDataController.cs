using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveDataController : MonoBehaviour
{
    private PlayerData _data;
    private Player _player;
    private void Start()
    {
        _player = FindObjectOfType<Player>();
        LoadField();
        _player.HighScore = _data.Highscore;
    }
    private void LoadField()
    {
        _data = JsonUtility.FromJson<PlayerData>(File.ReadAllText(Application.streamingAssetsPath + "/Player Data.json"));
        //_player.Score = _data.Highscore;
    }
    public void SaveField()
    {
        _data.Highscore = _player.HighScore;
        File.WriteAllText(Application.streamingAssetsPath + "/Player Data.json", JsonUtility.ToJson(_data));
    }
    [System.Serializable]
    public class PlayerData
    {
        public long Highscore;
    }
}
