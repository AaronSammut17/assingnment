using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {

    //player 1 will use the up and down arrow keys to controll the leftPaddle.
    //player 2 will use the mouse to controll the rightPaddle.

    public GameObject leftPaddle;
    public GameObject rightPaddle;
  
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //default speed of paddle is 0
        leftPaddle.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);

            //if the player1 pressed the upArrow
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //left paddle goes up
                leftPaddle.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 5f, 0f);
            }
            //if the player1 pressed the downArrow
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                //left paddle goes down
                leftPaddle.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -5f, 0f);
            }

        //default speed of paddle is 0
        rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);

            //if the player2 pressed the left button of the mouse
            if (Input.GetKey(KeyCode.Mouse0))
            {
                //right paddle goes up
                rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 5f, 0f);
            }
            //if the player2 pressed the right button of the mouse
            else if (Input.GetKey(KeyCode.Mouse1))
            {
                //right paddle goes down
                rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -5f, 0f);
            }
    }
}
