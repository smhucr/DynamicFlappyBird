using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed;
    private void Update()
    {
        if (!GameManager.instance.endGame)
            transform.Translate(Vector3.right * Time.deltaTime * forwardSpeed);
    }
}
