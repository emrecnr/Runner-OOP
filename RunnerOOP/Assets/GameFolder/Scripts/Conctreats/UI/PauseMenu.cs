using RunnerOOP.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.UI
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] GameObject _pauseMenuPanel;
        private string _mainMenuSceneName = "MainMenu";
        private string _gameSceneName = "Game";
        private void Awake()
        {
            _pauseMenuPanel.SetActive(false);
        }
        public void PauseGame()
        {

            _pauseMenuPanel?.SetActive(true);
            GameManager.Instance.IsGamePause = true;
        }
        public void ResumeGame()
        {
            _pauseMenuPanel?.SetActive(false);
            GameManager.Instance.IsGamePause = false;
        }
        public void MainMenu()
        {
            GameManager.Instance.LoadScene(_mainMenuSceneName);
            AudioManager.Instance.CheckGameStatus(_mainMenuSceneName);
        }
        public void RetryGame()
        {
            GameManager.Instance.LoadScene(_gameSceneName);
            
        }
        public void QuitGame()
        {
            GameManager.Instance.QuitGame();
        }
        public void MuteMusic()
        {
            AudioManager.Instance.MuteMusic();
        }

    }
}

