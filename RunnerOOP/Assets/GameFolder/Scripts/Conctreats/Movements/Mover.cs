using RunnerOOP.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.Movements
{
    public class Mover
    {
        PlayerController _playerController;
        float _moveSpeed = 5f;
        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void Move(float horizontalInput)
        {
            if (horizontalInput==0) { return; }
            _playerController.transform.Translate(Vector3.right*horizontalInput*_moveSpeed*Time.deltaTime);
        }
    }

}

    

