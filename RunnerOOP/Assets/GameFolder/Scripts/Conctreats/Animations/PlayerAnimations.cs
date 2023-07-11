using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.Animations
{
    public class PlayerAnimations
    {
        Animator _playerAnimator;
        public PlayerAnimations(Animator playeAnimator)
        {
            _playerAnimator = playeAnimator;
           
        }

        public void SetTriggerJump()
        {
            if (_playerAnimator == null) { return; }

            _playerAnimator.SetTrigger("isJump");
            
        }
        public void ResetTriggerJump()
        {
            if (_playerAnimator == null) { return; }
            _playerAnimator.ResetTrigger("isJump");
        }

    }

}

