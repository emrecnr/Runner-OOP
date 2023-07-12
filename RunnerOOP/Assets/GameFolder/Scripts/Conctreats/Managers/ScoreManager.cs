using RunnerOOP.Abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace RunnerOOP.Managers
{

    public class ScoreManager : SingletonObject<ScoreManager>
    {
        int _score;
       [SerializeField] TextMeshProUGUI _scoreText;
        public int Score 
        {
            get { return _score; }
            set { _score = value; } 
        }
        private void Awake()
        {
            CheckInstance(this);
            _score = 0;
            _scoreText.text = _score.ToString();
        }
        public void UpdateScore()
        {
            if (GameManager.Instance.IsGameOver) { return; }
            _score++;
            _scoreText.text = _score.ToString();
        }

    }

}

