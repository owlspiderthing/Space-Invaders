using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{   

    public Rigidbody2D rb;
    public Camera cam;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("move", 2.0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void move()
    {
        
    }
}
