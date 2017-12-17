using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour {

    //this object is created so that the values and methods of this class 
    //can be used in other classes.
    public static score instance;

    //these object will be connected to the scores of the game in level 1
    public Text playerOneScore;
    public Text playerTwoScore;

    //two variables are created
    public int playerOne;
    public int playerTwo;
    

    // Use this for initialization
    void Start () {
        instance = this;
        
	}

    // Update is called once per frame
    void Update() {

    }

    //it will add the score of player 1 when it is called and will change the text
    public void addPlayer1Score ()
    {
        playerOne += 1;
        playerOneScore.text = playerOne.ToString();
    }

    //it will add the score of player 2 when it is called and will change the text
    public void addPlayer2Score()
    {
        playerTwo += 1;
        playerTwoScore.text = playerTwo.ToString();
    }

    
}
