using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    //this will be connected to the text in the winner scene
    public Text Body;

    //here it will add all of player 1 score togather
    public static int totalPlayerOne()
    {
        //here it is calling all the scores of player 1 from the classes score ,score2 and score3
        int total = score.instance.playerOne + score2.instance.playerOne + score3.instance.playerOne;
        return total;
    }

    //here it will add all of player 2 score togather
    public static int totalPlayerTwo()
    {
        //here it is calling all the scores of player 2 from the classes score ,score2 and score3
        int total = score.instance.playerTwo + score2.instance.playerTwo + score3.instance.playerTwo;
        return total;
    }

    //checking which one is the winner
    public void CheckWinner()
    {
        //checks if player 1 score is bigger then player 2
        if (totalPlayerOne() > totalPlayerTwo())
        {
            //it will store this paragrah in the variable words 
            string words = "The winner is player One with " + totalPlayerOne() + " points, while player Two got " + totalPlayerTwo() + " points..";
            //it is grapping the variable words and it will dispplay it in the UI
            Body.text = words;
            
        }

        //checks if player 2 score is bigger then player 1
        if (totalPlayerOne() < totalPlayerTwo())
        {
            //it will store this paragrah in the variable words 
            string words = "The winner is player Two with " + totalPlayerTwo() + " points, while player One got " + totalPlayerOne() + " points..";
            //it is grapping the variable words and it will dispplay it in the UI
            Body.text = words;
        }
    }
    
    // Use this for initialization
    void Start()
    {
        //calling method checkWinner
        CheckWinner();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
}
