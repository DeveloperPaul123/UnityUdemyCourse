using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;

    private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
        // take difference of coordinates of ball and paddle
        paddleToBallVector = this.transform.position -
            paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            // launch the ball
            GetComponent<Rigidbody2D>().velocity =
                new Vector2(2f, 10f);
        }
	}
}
