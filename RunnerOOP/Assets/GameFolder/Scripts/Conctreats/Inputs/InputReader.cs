using RunnerOOP.Abstracts.Inputs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RunnerOOP.Inputs
{
    public class InputReader : IInputs
    {
        float _horizontal;
        bool _isJump;
        PlayerInput _playerInput;
        public float Horizontal => _horizontal;

        public bool IsJump => _isJump;

        public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;
            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
            _playerInput.currentActionMap.actions[1].performed += OnJump;
        }

        private void OnJump(InputAction.CallbackContext context)
        {

            _isJump = context.ReadValueAsButton();
        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            _horizontal = context.ReadValue<float>();
        }


    }

}

