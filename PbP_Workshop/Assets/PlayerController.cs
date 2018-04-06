using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour{

    // INITIALISE VARIABLES //
    GameObject Player;

    // UI Variables
    public Text ScoreText;
    public Text EndGameText;
    private int iScore = 0;

    // Movement variables
    public Vector3 vMove;

    // Game State
    private bool GameOver = false;

	// Use this for initialization
	void Start ()
    {
        // Set up private variables (all public variables are set in the inspector)
        Player = GameObject.Find("Player");
        ScoreText.text = "Score: " + iScore.ToString(); ;
        EndGameText.text = "";
    }

    void Update()
    {   
        Movement();
    }

    void Movement()
    {
        if(!GameOver) // If the player hasn't died or killed all of the enemies
        {
            // 'A' moves left, 'D' moves right
            if(Input.GetKey(KeyCode.A))
            {
                Player.transform.position -= (vMove);
            }
            else if(Input.GetKey(KeyCode.D))
            {
                Player.transform.position += (vMove);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // If the player has collided with an enemy
        if(col.collider.tag == "Enemy")
        {
            //Player gets hit by an enemy or enemy bullet
            GameEnd("Lose");
        }
    }

    void GameEnd(string _sGameEnd)
    {
        // if the player has won
        if (_sGameEnd == "Win")
        {
            EndGameText.text = "You Win";
        }
        // if the player has lost
        else if(_sGameEnd == "Lose")
        {
            EndGameText.text = "You Lose";
        }

        GameOver = true;
        Player.SetActive(false);
    }
}