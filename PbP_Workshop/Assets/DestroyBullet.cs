using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
