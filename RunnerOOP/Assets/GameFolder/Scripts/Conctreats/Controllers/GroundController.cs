using RunnerOOP.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RunnerOOP.Controllers
{
    public class GroundController : MonoBehaviour
    {
       float _moveSpeed = 2.50f;

        Material _material;

        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;
            
        }

        private void Update()
        {
            if (GameManager.Instance.IsGameOver||GameManager.Instance.IsGamePause)
            {
                return;
            }
            _material.mainTextureOffset += Vector2.up * _moveSpeed * Time.deltaTime;
        }
    }

}

