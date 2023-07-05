using RunnerOOP.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace RunnerOOP.UI
{

    public class GameOverUI : MonoBehaviour
    {
        
        [SerializeField] GameObject gameOverPanel;

        private void Awake()
        {
            gameOverPanel.gameObject.SetActive(false);
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameStop += HandleOnGameStop;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameStop;
        }

        private void HandleOnGameStop()
        {
            gameOverPanel.gameObject.SetActive(true);
        }
    }


}

