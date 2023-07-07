using RunnerOOP.Managers;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace RunnerOOP.UI
{
    public class MainMenu : MonoBehaviour
    {
        private string _nextScene = "Game";

        private float skyboxSpeed = 10f;

       
        private void Update()
        {
            //rotate skybox background
            RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxSpeed);
        }
        
        public void PlayButton()
        {
            GameManager.Instance.LoadScene(_nextScene);
            AudioManager.Instance.CheckGameStatus(_nextScene);
        }
        public void QuitButton()
        {
            // Application.Quit();
            GameManager.Instance.QuitGame();
        }
        public void MuteButton()
        {
            
            AudioManager.Instance.MuteMusic();

        }
       
        
    }


}

