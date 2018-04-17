using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Nemo : MonoBehaviour {

    float speed = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(transform.position.x, transform.position.y+speed);

        if (transform.position.y >= 7.0f)
        {
            Destroy(gameObject);
        }
    }


}
