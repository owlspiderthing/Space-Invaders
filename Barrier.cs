using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int health = 5;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        health = health - 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
            
    }

}
