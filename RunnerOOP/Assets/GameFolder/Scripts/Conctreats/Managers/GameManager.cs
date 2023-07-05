using RunnerOOP.Abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RunnerOOP.Managers
{
    public class GameManager : SingletonObject<GameManager>
    {
        private bool _isGameOver;
        public bool IsGameOver => _isGameOver;

        public event System.Action OnGameStop;
        private void Awake()
        {
            CheckInstance(this);
            
        }

        public void StopGame()
        {
            OnGameStop?.Invoke();
            Time.timeScale = 0;
            
        }
        public void QuitGame()
        {
            Application.Quit();
            
        }
        
        
        public void LoadScene(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }

}

