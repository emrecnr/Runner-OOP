using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    
        private bool isTouchingLayer;

    public bool IsTouchingLayer 
    {
        get { return isTouchingLayer; }
        set { isTouchingLayer = value; }
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isTouchingLayer = true;
        }

        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isTouchingLayer = false;
        }
    }






}
