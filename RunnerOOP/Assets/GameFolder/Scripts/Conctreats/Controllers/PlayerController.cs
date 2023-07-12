using RunnerOOP.Abstracts.Inputs;
using RunnerOOP.Animations;
using RunnerOOP.Inputs;
using RunnerOOP.Managers;
using RunnerOOP.Movements;
using System.Collections;
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


        private void Start()
        {
            StartCoroutine(StartAnimation());
        }
        private void Update()
        {
           
            
            _mover.CheckLineAndMove();

            _jump.CheckJumpState(_OnGround.IsTouchingLayer);
            
        }
        
        
        private void OnTriggerEnter(Collider other)
        {
            if (GameManager.Instance.IsGamePause || GameManager.Instance.IsGameOver) return;
            if (other.gameObject.CompareTag("Obstacles"))
            {
                GameManager.Instance.StopGame();
                GameManager.Instance.IsGameOver = true;
                _playerAnimations.FallAnimation();
            }
            if (other.gameObject.CompareTag("Coin"))
            {
                ScoreManager.Instance.UpdateScore();
                Destroy(other.gameObject);
            }
        }
        IEnumerator StartAnimation()
        {
            _playerAnimations.SetTriggerStartAnimation();
            yield return new WaitForSeconds(1.2f);
            GameManager.Instance.IsGameOver = false;
            yield return null;

        }








    }


}

