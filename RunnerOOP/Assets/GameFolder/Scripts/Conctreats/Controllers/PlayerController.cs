using RunnerOOP.Abstracts.Inputs;
using RunnerOOP.Inputs;
using RunnerOOP.Managers;
using RunnerOOP.Movements;

using UnityEngine;


namespace RunnerOOP.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Mover _mover;
        Jump _jump;
        OnGround _OnGround;
        

        
        private void Awake()
        {
            
            _jump = new Jump(GetComponent<Rigidbody>());
            _mover = new Mover(this);
            _OnGround=GetComponentInChildren<OnGround>();
            
        }


        private void Update()
        {
            Debug.Log(_OnGround.IsTouchingLayer);
            if (GameManager.Instance.IsGamePause) return;
            _mover.CheckLineAndMove();
        }
        private void FixedUpdate()
        {
            if (GameManager.Instance.IsGamePause) return;
            
            _jump.CheckJumpState(_OnGround.IsTouchingLayer);
                
            
            
            
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Obstacles"))
            {
                GameManager.Instance.StopGame();
                GameManager.Instance.IsGameOver = true;
            }
        }

            
            
            


         


    }


}

