using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Nemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            transform.position  = new Vector3(transform.position.x -0.3f, transform.position.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + 0.3f, transform.position.y);
        }

        //Agreed a good idea to talk about GetKey, GetKeyDown, GetKeyUp now!
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Resources.Load("Bullet_Nemo"));
        }

    }
}
