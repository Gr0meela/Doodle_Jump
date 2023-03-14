using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
    [SerializeField] private GameObject _gameCanvas;
    [SerializeField] private GameObject _pauseCanvas;

    void Start()
    {
        Unpause();
    }
    public void Pause()
    {
        _gameCanvas.SetActive(false);
        _pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Unpause()
    {
        _gameCanvas.SetActive(true);
        _pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
