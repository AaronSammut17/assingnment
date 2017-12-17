using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    
    //this method will load the level that is inputed
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    //this method wll load the next level 
    public void LoadNextLevel()
    {
        //checks if it is on level 1
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            //if it is on level 1 it will check the score 
            if (score.instance.playerOne == 5)
            {
                //if the score of player 1 is 5 it will go to the next level
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (score.instance.playerTwo == 5)
            {
                //if the score of player 2 is 5 it will go to the next level
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        //checks if it is on level 2
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            //if it is on level 2 it will check the score 
            if (score2.instance.playerOne == 10)
            {
                //if the score of player 1 is 10 it will go to the next level
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (score2.instance.playerTwo == 10)
            {
                //if the score of player 2 is 10 it will go to the next level
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        //checks if it is on level 3
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            //if it is on level 3 it will check the score 
            if (score3.instance.playerOne == 15)
            {
                //if the score of player 1 is 15 it will go to the next level
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (score3.instance.playerTwo == 15)
            {
                //if the score of player 2 is 15 it will go to the next level
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    void Update()
    {
        //calling the method to check the scores so it can contineu to the next level
        LoadNextLevel();
    }

    //this method will exit the game
    public void QuitLevel()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
