using RunnerOOP.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RunnerOOP.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        VerticalMover _mover;

        private void Awake()
        {
            _mover = new VerticalMover(this);
        }
        private void FixedUpdate()
        {
            _mover.MoveVertical();
        }
        
    }
}

