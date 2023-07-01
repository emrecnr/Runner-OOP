using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RunnerOOP.Controllers
{
    public class GroundController : MonoBehaviour
    {
        float _moveSpeed = .5f;

        Material _material;

        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;
        }

        private void Update()
        {
            _material.mainTextureOffset += Vector2.down * _moveSpeed * Time.deltaTime;
        }
    }

}

