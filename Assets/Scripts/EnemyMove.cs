using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float speed = 20f;
    public float YPos = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Destroy();
    }

 void Move()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void Destroy()
    {
        if (transform.position.z < -30)
        {
            Destroy(gameObject);
        }
    }
}
