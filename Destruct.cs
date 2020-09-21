using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct : MonoBehaviour
{   
    GameObject ShootShoot = GameObject.Find("EnemyController");
    PlayerScript enemylol = ShootShoot.GetComponent<EnemyShooting>();
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        enemylol.EnemiesLeft = enemylol.EnemiesLeft - 1f;
    }
}
