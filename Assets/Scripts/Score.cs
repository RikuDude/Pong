using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    [SerializeField]
    private Text paddleScore = null;
    public GameObject ballPrefab;
    
    //public Transform paddleObj;

    public GameObject ball;
    int score = 0;
    


	void Start () {
		
	}
	
	void Update () {
        ball = GameObject.FindGameObjectWithTag("Ball");
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            score = score + 1;
            paddleScore.text = "" + score;
            Destroy(ball);
            Instantiate(ballPrefab, new Vector2(0F, 0F), Quaternion.identity);
        }
        //Instantiate(ballPrefab, new Vector2(0F, 0F), Quaternion.identity);
        //Destroy(ball);
        //score = score++;
        //paddleScore.GetComponent<Text>().text = "" + score;
    }
}
