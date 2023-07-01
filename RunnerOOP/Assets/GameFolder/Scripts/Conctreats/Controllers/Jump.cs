using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerOOP.Movements
{
    public class Jump
    {
        Rigidbody _playerRigidbody;
        float _jumpForce=1f;
       
        public Jump(Rigidbody playerRigidbody)
        {
            _playerRigidbody = playerRigidbody;
        }


        public void Jumping()
        {
            _playerRigidbody.AddForce(Vector3.up*_jumpForce,ForceMode.Impulse);
        }

    }

}

