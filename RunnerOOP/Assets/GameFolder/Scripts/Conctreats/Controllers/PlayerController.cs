using RunnerOOP.Abstracts.Inputs;
using RunnerOOP.Inputs;
using RunnerOOP.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RunnerOOP.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Mover _mover;
        Jump _jump;
        IInputs _inputs;
        
        
        private void Awake()
        {
            _mover = new Mover(this);
            _jump = new Jump(GetComponent<Rigidbody>());
            _inputs = new InputReader(GetComponent<PlayerInput>());
            
        }


        private void Update()
        {
            
            _mover.Move(_inputs.Horizontal);
            Debug.Log(_inputs.IsJump);
            
        }
        private void FixedUpdate()
        {
            if (_inputs.IsJump)
            {
                _jump.Jumping();
            }
            




        }
    }


}

