using RunnerOOP.Abstracts.Inputs;
using RunnerOOP.Animations;
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
        PlayerAnimations _playerAnimations;
        

        
        private void Awake()
        {
            _playerAnimations = new PlayerAnimations(GetComponent<Animator>());
            _jump = new Jump(GetComponent<Rigidbody>(),_playerAnimations);
            _mover = new Mover(this);
            _OnGround=GetComponentInChildren<OnGround>();
            

        }


        private void Update()
        {
           
            if (GameManager.Instance.IsGamePause) return;
            _mover.CheckLineAndMove();

            _jump.CheckJumpState(_OnGround.IsTouchingLayer);
        }
        private void FixedUpdate()
        {
            if (GameManager.Instance.IsGamePause) return;
            
            
                
            
            
            
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

