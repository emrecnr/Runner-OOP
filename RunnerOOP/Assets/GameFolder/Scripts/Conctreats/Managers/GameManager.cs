using RunnerOOP.Abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.Managers
{
    public class GameManager : SingletonObject<GameManager>
    {
        private void Awake()
        {
            CheckInstance(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0;

        }
    }

}

