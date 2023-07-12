using RunnerOOP.Managers;
using RunnerOOP.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RunnerOOP.Controllers
{

    public class CoinController : MonoBehaviour
    {
        VerticalMover _mover;

        float _moveSpeed = 10f;
        private void Awake()
        {
            _mover = new VerticalMover(gameObject);

        }

        private void FixedUpdate()
        {
            if (GameManager.Instance.IsGamePause ||GameManager.Instance.IsGameOver) { return; }
            _mover.MoveVertical(_moveSpeed);
        }
        
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Obstacles"))
            {
                Debug.Log("Destroy");
                Destroy(this.gameObject);

            }
        }
    }

}

