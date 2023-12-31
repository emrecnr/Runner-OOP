using RunnerOOP.Managers;
using RunnerOOP.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RunnerOOP.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        VerticalMover _mover;

        float _moveSpeed = 10f;

        private void Awake()
        {
            _mover = new VerticalMover(this.gameObject);
        }
        private void FixedUpdate()
        {
            if (GameManager.Instance.IsGamePause) { return; }
            _mover.MoveVertical(_moveSpeed);
        }

        
    }
}

