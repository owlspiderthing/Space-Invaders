using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float EnemiesLeft = 21f;
    public Transform PewPewPoint;
    public bool controlbool = false;
    public float bulletForce = 20f;
    public float damage = 20f;
    public GameObject EnemyBulletPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("pewpew", 2.0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemiesLeft == 0f)
        {
            controlbool = true;
        }
    }

    void pewpew()
    {
        if (controlbool = false)
        {
            GameObject Lightning = Instantiate(EnemyBulletPrefab, PewPewPoint.position, PewPewPoint.rotation);
            Rigidbody2D rb = Lightning.GetComponent<Rigidbody2D>();
            rb.AddForce(PewPewPoint.up * bulletForce, ForceMode2D.Impulse);
        }
        
    }

    


}
