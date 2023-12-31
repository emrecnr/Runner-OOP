using RunnerOOP.Abstracts.Utilities;
using RunnerOOP.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RunnerOOP.Managers
{
    public class GameManager : SingletonObject<GameManager>
    {
        
        public event System.Action OnGameStop;
        public event System.Action OnGamePause;

        bool _isGamePause;
        bool _isGameOver= true;
        string _activeSceneName;
        public string ActiveScene => _activeSceneName;


        public bool IsGamePause
        {
            get { return _isGamePause; }
            set { _isGamePause = value; }
        }

        public bool IsGameOver 
        {
            get { return _isGameOver; }
            set { _isGameOver = value; }
        
        
        }
        private void Awake()
        {
            CheckInstance(this);
            
            
            
        }

        public void StopGame()
        {
            OnGameStop?.Invoke();
            _isGamePause = true;
            
        }
        public void QuitGame()
        {
            Application.Quit();
            
        }
        
       
        

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
            _activeSceneName = sceneName;
            _isGamePause = false;
            if (!_isGameOver)
            {
                _isGameOver = true;

            }
            
        }
    }

}

