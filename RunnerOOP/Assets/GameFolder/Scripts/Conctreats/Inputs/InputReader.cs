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
        PlayerInput _playerInput;
        public float Horizontal => _horizontal;

        public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;
            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            _horizontal = context.ReadValue<float>();
        }
    }

}

