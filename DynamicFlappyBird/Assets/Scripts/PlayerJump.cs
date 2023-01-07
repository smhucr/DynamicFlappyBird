using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public Vector2 jumping;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigid.velocity = Vector2.zero;
            myRigid.AddForce(jumping);
        }
    }


}
