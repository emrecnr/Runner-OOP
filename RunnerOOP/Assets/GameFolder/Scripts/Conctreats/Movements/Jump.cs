using RunnerOOP.Animations;
using RunnerOOP.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

namespace RunnerOOP.Movements
{
    public class Jump
    {





        Rigidbody _playerRigidbody;
        PlayerAnimations _playerAnimations;
        float _jumpForce = 300f;
        float _deltaY;
        bool _jump;
        
        public Jump(Rigidbody playerRigidbody, PlayerAnimations playerAnimations)
        {
            _playerRigidbody = playerRigidbody;
            _playerAnimations = playerAnimations;
            Debug.Log(_playerAnimations);
        }


        private void Jumping()
        {


            _playerRigidbody.AddForce(Vector3.up * _jumpForce);

        }






        private void Animations()
        {
            if (GameManager.Instance.IsGameOver) { return; }
            _playerAnimations.SetTriggerJump();
            
            
        }
        public void CheckJumpState(bool canJump)
        {
            if (GameManager.Instance.IsGameOver||GameManager.Instance.IsGamePause) { return; }

            if (canJump)
            {

                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);

                    if (touch.phase == TouchPhase.Began)
                    {
                        Debug.Log("began");
                        _jump = true;
                        

                    }

                   else if (touch.phase == TouchPhase.Moved&&_jump)
                    {
                        Debug.Log("moved");
                        _deltaY = touch.deltaPosition.y;
                        if (_deltaY > 5)
                        {
                            _deltaY = 0;
                            Animations();
                            Jumping();
                            _jump = false;
                        }





                    }


                }
            }

        }

    }
}














