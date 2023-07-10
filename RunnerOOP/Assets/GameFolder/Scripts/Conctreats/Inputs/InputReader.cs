using RunnerOOP.Abstracts.Inputs;
using RunnerOOP.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RunnerOOP.Inputs
{
    public class InputReader : IInputs
    {
        
        bool _isJump;
        PlayerController _playerController;
        

        public bool IsJump => _isJump;
        
        public InputReader(PlayerController playerController)
        {
            _playerController = playerController;

        }
        
        
        //private void OnJump(InputAction.CallbackContext context)
        //{

        //    _isJump = context.ReadValueAsButton();
        //}

        //private void OnHorizontalMove(InputAction.CallbackContext context)
        //{
        //    _horizontal = context.ReadValue<float>();
        //}


    }

}
    

