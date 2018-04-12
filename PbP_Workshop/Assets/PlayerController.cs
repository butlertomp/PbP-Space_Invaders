using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour{

    // INITIALISE VARIABLES //
    GameObject Player;
    GameObject gBullet;

    // Movement variables
    public Vector3 vMove;

    // Game State
    private bool GameOver = false;

	// Use this for initialization
	void Start ()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {   
        if(!GameOver) // If the player hasn't died or killed all of the enemies
        {
            Movement();
            Shoot();
        }
    }

    void Movement()
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


    /*---------------------------------------------------------------------------------------------
     * Might be a cool idea to talk about the different uses of GetKeyDown, GetKeyUp, and GetKey
     * GetKeyDown - As soon as you push 'Space', the bullet fires
     * GetKeyUp - As soon as you release 'Space', the bullet fires
     * GetKey - Rapid fire
    ---------------------------------------------------------------------------------------------*/
    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))             
        {
            Instantiate(Resources.Load("Bullet"));
        }                                               
    }

    void OnCollisionEnter2D(Collision2D col)
    {

    }
}