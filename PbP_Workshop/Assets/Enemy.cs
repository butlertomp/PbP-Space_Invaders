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

    Vector3 EnemyOGPos;
    Vector3 EnemyUpdatedPos;


    void Start()
    {
        gEnemy = this.gameObject;
        EnemyRight = true;

        EnemyOGPos = gEnemy.transform.position;
        EnemyUpdatedPos = EnemyOGPos;

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

            if (EnemyRight && EnemyUpdatedPos.x - EnemyOGPos.x >= 4)
            {
                gEnemy.transform.position -= vVerMoveSpeed;
                EnemyRight = false;
            }
            else if(EnemyRight)
            {
                gEnemy.transform.position += vHorMoveSpeed;
                EnemyUpdatedPos = gEnemy.transform.position;
            }
            else if(!EnemyRight && EnemyUpdatedPos.x - EnemyOGPos.x <= 0)
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

    void TakeDamage(int _iDamage)
    {
        iHealth -= _iDamage;

        if(iHealth <= 0)
        {
            Destroy(gEnemy);
        }
    }

    void Shoot()
    {

    }
}
