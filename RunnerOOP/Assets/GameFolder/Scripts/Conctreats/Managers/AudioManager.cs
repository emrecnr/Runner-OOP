using RunnerOOP.Abstracts.Utilities;
using RunnerOOP.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RunnerOOP.Managers
{
    public class AudioManager : SingletonObject<AudioManager>
    {
        AudioSource _audioSource;
        AudioClip _menuAuidoClip;
        [SerializeField] AudioClip _gameAudioCip;
        
        
        
        bool _isPressMute ;
        public bool IsPressMute
        {
            get { return _isPressMute; }
            set { _isPressMute = value; }

        }
        private void Awake()
        {
            CheckInstance(this);
            _isPressMute = false;
            _audioSource = GetComponent<AudioSource>();
            _menuAuidoClip=_audioSource.clip;
            


        }
        public void CheckGameStatus(string sceneName)
        {
            if (sceneName == "Game")
            {
                _audioSource.clip = _gameAudioCip;  

            }
            else if (sceneName == "MainMenu")
            {
                _audioSource.clip = _menuAuidoClip;
            }
            _audioSource.Play();
        }
       
        public void MuteMusic()
        {
            _isPressMute = !_isPressMute;
            _audioSource.mute = _isPressMute;
            
            
        }


    }

}

