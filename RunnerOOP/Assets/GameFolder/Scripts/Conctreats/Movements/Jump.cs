using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

namespace RunnerOOP.Movements
{
    public class Jump
    {





        Rigidbody _playerRigidbody;
        float _jumpForce = 3f;
        float _deltaY;

        public Jump(Rigidbody playerRigidbody)
        {
            _playerRigidbody = playerRigidbody;
        }


        private void Jumping()
        {


            _playerRigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);



        }

        public void CheckJumpState(bool canJump)
        {
            if (canJump)
            {
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);


                    if (touch.phase == TouchPhase.Moved)
                    {
                        _deltaY = touch.deltaPosition.y;
                        if (_deltaY > 0)
                        {





                            Jumping();
                            

                        }

                    }
                    

                }
            }
            
        }

    }

}

