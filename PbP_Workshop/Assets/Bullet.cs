using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    GameObject Player;
    GameObject bullet;

    public float fMoveSpeed;

	// Use this for initialization
	void Start ()
    {
        Player = GameObject.Find("Player");
        bullet = gameObject;

        bullet.transform.position = Player.transform.position + new Vector3(0.0f, Player.transform.position.y + 3.5f, 0.0f);
    }
	
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        bullet.transform.position += new Vector3(0.0f, fMoveSpeed, 0.0f);

        // If the bullet is higher than the camera view, delete it
        if (bullet.transform.position.y >= 7.0f)
        {
            DestoryBullet();
        }
    }

    public void DestoryBullet()
    {
        Destroy(bullet);
    }
}