using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float ballSpeed = (float)0.1;
    //public Vector3 ballPosition;
    public float yBallSpeed;
    public float xBallSpeed;
    Rigidbody2D rb;



    void Start()
    {
        InitiateBallMovement();

        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = false;



        // Force method or
        rb.AddForce(new Vector2(xBallSpeed, yBallSpeed));
        //
        //rb.velocity = new Vector2(xBallSpeed, yBallSpeed);

    }

    // Update is called once per frame
    void Update()
    {

        //rb.AddForce(new Vector2(xBallSpeed, yBallSpeed));
        //rb.AddForce(new Vector2(xBallSpeed, yBallSpeed));
        //rb.AddForce(new Vector2(xBallSpeed, yBallSpeed));



        /*
        float yPos = gameObject.transform.position.y + yBallSpeed;
        float xPos = gameObject.transform.position.x + xBallSpeed;
        ballPosition = new Vector3(xPos, yPos);
        gameObject.transform.position = ballPosition;
        */

    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name.Equals("paddle1"))
        {

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

    }

    void InitiateBallMovement()
    {

        yBallSpeed = Random.Range(0, ballSpeed * 2 / 3);
        xBallSpeed = Mathf.Sqrt(Mathf.Pow(ballSpeed, 2) - Mathf.Pow(yBallSpeed, 2));
        if (Random.Range(0, 2) < 1)
        {
            yBallSpeed = -yBallSpeed;
        }

        if (Random.Range(0, 2) < 1)
        {
            xBallSpeed = -xBallSpeed;
        }

    }


}
