using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2Movement : MonoBehaviour
{

    public float paddleSpeed = 1;
    public Vector3 paddle1Position;


    void Update()
    {
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Paddle2Vertical") * paddleSpeed);

        paddle1Position = new Vector3(4, Mathf.Clamp(yPos, (float)-2.7, (float)2.7));
        gameObject.transform.position = paddle1Position;

    }
}
