using RunnerOOP.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.Movements
{
    public class Mover
    {
        PlayerController _playerController;
        
        float _moveSpeed = 20f;
        int currentLine = 1;
        int nextLine;
        float deltaX;
        float deltaY;
        private bool isSwipeInProgress = false;
        

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            
        }


        public void CheckLineAndMove()
        {
            CheckTouchDeltaPositionX();
            Vector3 targetPosition = _playerController.transform.position;

            if (currentLine == 0)
            {
                targetPosition.x = -3;
            }
            else if (currentLine == 1)
            {
                targetPosition.x = 0f;
            }
            else if (currentLine == 2)
            {
                targetPosition.x = 3;
            }
            

            _playerController.transform.position = Vector3.Lerp(_playerController.transform.position, targetPosition, _moveSpeed * Time.deltaTime);
        }

        private void CheckTouchDeltaPositionX()
        {
            
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    isSwipeInProgress = true;
                    
                }



                else if (touch.phase == TouchPhase.Moved&&isSwipeInProgress)
                {
                    
                    deltaX = touch.deltaPosition.x;
                    deltaY = touch.deltaPosition.y;

                    if (deltaX > 10f)
                    {
                        currentLine++;
                        if (currentLine == 3)
                        {
                            currentLine = 2;
                        }
                        isSwipeInProgress = false;

                    }
                    else if (deltaX < -10f)
                    {
                        currentLine--;
                        if (currentLine == -1)
                        {
                            currentLine = 0;
                        }
                        isSwipeInProgress = false;
                    }
                    
                        

                    
                }

               

                
            }
        }



    }
}



