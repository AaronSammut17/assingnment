using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ball : MonoBehaviour {

    //reference to the rigidbody
    Rigidbody2D rigidbody2d;

	// Use this for initialization
	void Start () {
        
        //It will make a shortcut to rigidbody component
        rigidbody2d = GetComponent<Rigidbody2D>();

        //wait 2 seconds before launching ball
        StartCoroutine(Pause());
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void launchBall()
    {

        //Random direction was set to the ball.
        int x = Random.Range(0, 2);
        int y = Random.Range(0, 2);

        Vector3 direction = new Vector3();
        
        //this will make a random position for the ball
        if (x == 0)
        {
            direction.x = 3f;
        }
        if (x == 1)
        {
            direction.x = -3f;
        }
        if (y == 0)
        {
            direction.y = 3f;
        }
        if (y == 1)
        {
            direction.y = -3f;
        }
        rigidbody2d.velocity = direction;
    }

    IEnumerator Pause()
    {
        //wait for 2 seconds
        yield return new WaitForSeconds (2f);
        //calls the function to launch the ball
        launchBall();
    }

    //this method will check which object the ball collided with
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //checks if the ball hits the top collider
        if (collision.gameObject.name == "top")
        {
            float speedInX = 0f;

            if (rigidbody2d.velocity.x > 0f)
                speedInX = 3f;

            if (rigidbody2d.velocity.x < 0f)
                speedInX = -3f;

            rigidbody2d.velocity = new Vector3(speedInX, -3f, 0f);
        }

        //checks if the ball hits the bottom collider
        if (collision.gameObject.name == "bottom")
        {
            float speedInX = 0f;

            if (rigidbody2d.velocity.x > 0f)
                speedInX = 3f;

            if (rigidbody2d.velocity.x < 0f)
                speedInX = -3f;

            rigidbody2d.velocity = new Vector3(speedInX, 3f, 0f);
        }

        //checks if the ball hits the left paddle
        if (collision.gameObject.name == "leftPaddle")
        {
            //this will be used if the ball hits the middle of the paddle
            rigidbody2d.velocity = new Vector3(4f, 0f, 0f);

            //checks if we hit the lower part of the paddle
            if (transform.position.y - collision.gameObject.transform.position.y <= -0.3)
            {
                rigidbody2d.velocity = new Vector3(-3f, -3f, 0f);
            }
            //checks if we hit the upper part of the paddle
            if (transform.position.y - collision.gameObject.transform.position.y >= 0.3)
            {
                rigidbody2d.velocity = new Vector3(3f, 3f, 0f);
            }
            
        }

        //checks if the ball hits the right paddle
        if (collision.gameObject.name == "rightPaddle")
        {
            //this will be used if the ball hits the middle of the paddle
            rigidbody2d.velocity = new Vector3(-4f, 0f, 0f);

            //checks if we hit the lower part of the paddle
            if (transform.position.y - collision.gameObject.transform.position.y <= -0.3)
            {
                rigidbody2d.velocity = new Vector3(-3f, -3f, 0f);
            }
            //checks if we hit the upper part of the paddle
            if (transform.position.y - collision.gameObject.transform.position.y >= 0.3)
            {
                rigidbody2d.velocity = new Vector3(3f, 3f, 0f);
            }
        }
    
        //it will check if it hits the collider behind the player 2 paddle
        if (collision.gameObject.name == "scorePl1")
        {
            //it will check if it is on level 1
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                //sets the position of the ball to the  middle
                transform.position = Vector3.zero;
                rigidbody2d.velocity = Vector3.zero;

                //it will the score of player 1 from the score class
                score.instance.addPlayer1Score();
                //it will start the ball from the middle
                StartCoroutine(Pause());
                
            }

            //it will check if it is on level 2
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                //sets the position of the ball to the  middle
                transform.position = Vector3.zero;
                rigidbody2d.velocity = Vector3.zero;

                //it will the score of player 1 from the score2 class
                score2.instance.addPlayer1Score();
                //it will start the ball from the middle
                StartCoroutine(Pause());
                
            }

            //it will check if it is on level 3
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                //sets the position of the ball to the  middle
                transform.position = Vector3.zero;
                rigidbody2d.velocity = Vector3.zero;

                //it will the score of player 1 from the score3 class
                score3.instance.addPlayer1Score();
                //it will start the ball from the middle
                StartCoroutine(Pause());
                
            }
        }

        //it will check if it hits the collider behind the player 1 paddle
        if (collision.gameObject.name == "scorePl2")
        {
            //it will check if it is on level 1
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                //sets the position of the ball to the  middle
                transform.position = Vector3.zero;
                rigidbody2d.velocity = Vector3.zero;

                //it will the score of player 2 from the score class
                score.instance.addPlayer2Score();
                //it will start the ball from the middle
                StartCoroutine(Pause());
            }

            //it will check if it is on level 2
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                //sets the position of the ball to the  middle
                transform.position = Vector3.zero;
                rigidbody2d.velocity = Vector3.zero;

                //it will the score of player 2 from the score2 class
                score2.instance.addPlayer2Score();
                //it will start the ball from the middle
                StartCoroutine(Pause());
            }

            //it will check if it is on level 3
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                //sets the position of the ball to the  middle
                transform.position = Vector3.zero;
                rigidbody2d.velocity = Vector3.zero;

                //it will the score of player 2 from the score3 class
                score3.instance.addPlayer2Score();
                //it will start the ball from the middle
                StartCoroutine(Pause());
            }
        }
    }
}
