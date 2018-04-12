using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{

    GameObject gEnemy;

    // ------ PUBLIC VARIABLES ------//
    public int iHealth;
    public float fMoveTimer;
    public float fShotTimer;

    public Vector3 vHorMoveSpeed;
    public Vector3 vVerMoveSpeed;

    // ------ PRIVATE VARIABLES ------//
    bool EnemyRight;

    Vector3 EnemyStartPos;
    Vector3 EnemyUpdatedPos;

    void Start()
    {
        gEnemy = gameObject;
        EnemyRight = true;

        EnemyStartPos = gEnemy.transform.position;
        EnemyUpdatedPos = EnemyStartPos;

        StartCoroutine(Movement());
    }

    void Update()
    {
        Shoot();
	}

    IEnumerator Movement()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(fMoveTimer);

            if (EnemyRight && EnemyUpdatedPos.x - EnemyStartPos.x >= 4)
            {
                gEnemy.transform.position -= vVerMoveSpeed;
                EnemyRight = false;
            }
            else if(EnemyRight)
            {
                gEnemy.transform.position += vHorMoveSpeed;
                EnemyUpdatedPos = gEnemy.transform.position;
            }
            else if(!EnemyRight && EnemyUpdatedPos.x - EnemyStartPos.x <= 0)
            {
                gEnemy.transform.position -= vVerMoveSpeed;
                EnemyRight = true;
            }                                               
            else                                 
            {                                     
                gEnemy.transform.position -= vHorMoveSpeed;
                EnemyUpdatedPos = gEnemy.transform.position;
            }
        }
    }

    void Shoot()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "Bullet")
        {
            Destroy(gEnemy);
            Destroy(col.collider.gameObject);
        }
    }
}
