using RunnerOOP.Managers;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace RunnerOOP.UI
{
    public class MainMenu : MonoBehaviour
    {
        private int nextScene = 1;

        private float skyboxSpeed = 10f;
            

        private void Update()
        {
            //rotate skybox background
            RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxSpeed);
        }
        
        public void PlayButton()
        {
            GameManager.Instance.LoadScene(nextScene);
        }
        public void QuitButton()
        {
            // Application.Quit();
            GameManager.Instance.QuitGame();
        }
       
        
    }


}

