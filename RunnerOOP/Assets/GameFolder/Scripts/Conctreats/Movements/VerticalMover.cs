using RunnerOOP.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.Movements
{

    public class VerticalMover 
    {
        EnemyController _enemyController;
        float _moveSpeed = 5f;
        public VerticalMover(EnemyController enemyController)
        {
           _enemyController = enemyController;
        }


        public void MoveVertical()
        {
            _enemyController.transform.Translate(Vector3.back*_moveSpeed*Time.deltaTime);
        }


    }

}

