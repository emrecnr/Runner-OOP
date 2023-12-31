using RunnerOOP.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RunnerOOP.UI
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] GameObject _pauseMenuPanel;
        private string _mainMenuSceneName = "MainMenu";
        private string _gameSceneName = "Game";
        [SerializeField] Sprite _musicOffSprite;
        private Sprite _musicOnImage;
        [SerializeField] Image _musicButtonImage;
        private void Awake()
        {
            _pauseMenuPanel.SetActive(false);
            _musicOnImage = _musicButtonImage.sprite;
        }
        public void PauseGame()
        {
            GameManager.Instance.IsGamePause = true;
            _pauseMenuPanel?.SetActive(true);
           
        }
        public void ResumeGame()
        {
            GameManager.Instance.IsGamePause = false;
            _pauseMenuPanel?.SetActive(false);
            
        }
        public void MainMenu()
        {
            GameManager.Instance.LoadScene(_mainMenuSceneName);
            AudioManager.Instance.CheckGameStatus(_mainMenuSceneName);
            PoolManager.Instance.ResetObjects();
        }
        public void RetryGame()
        {
            GameManager.Instance.LoadScene(_gameSceneName);
            PoolManager.Instance.ResetObjects();


        }
        public void QuitGame()
        {
            GameManager.Instance.QuitGame();
        }
        public void MuteMusic()
        {
           
           AudioManager.Instance.MuteMusic();
           if (AudioManager.Instance.IsPressMute)
            {
                _musicButtonImage.sprite = _musicOffSprite;
            }
            else
            {
                _musicButtonImage.sprite = _musicOnImage;
            }
            
        }

    }
}

