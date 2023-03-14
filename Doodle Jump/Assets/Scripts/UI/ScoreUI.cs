using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour
{
    private Player _player;
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _finalScoreText;
    [SerializeField] private Text _highScoreText;
    void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    void Update()
    {
        _scoreText.text = _player.Score.ToString();
        _finalScoreText.text = "Your score: "+ _player.Score.ToString();
        _highScoreText.text = "Highscore: " + _player.HighScore.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
