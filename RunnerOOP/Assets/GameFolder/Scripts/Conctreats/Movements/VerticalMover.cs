using RunnerOOP.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.Movements
{

    public class VerticalMover 
    {
        GameObject _gameObject;
        
       
        public VerticalMover(GameObject gameObject)
        {
           _gameObject = gameObject;
        }


        public void MoveVertical(float moveSpeed)
        {
            _gameObject.transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
            
        }


    }

}

