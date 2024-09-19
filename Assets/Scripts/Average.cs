using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Average : MonoBehaviour
{
    private Rigidbody averageRb;
    private bool ongrounded;
   
    // Start is called before the first frame update
    void Start()
    {
        averageRb = GetComponent<Rigidbody>();
        ongrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        jump();  
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            ongrounded = true;
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            Spawn.Instance.health -= 2;
            Debug.Log("Health Decreases");
            {
                if(Spawn.Instance.health==2)
                {
                    Destroy(gameObject);
                    Debug.Log("Death");
                    Spawn.Instance.isgameOver = true;
                }
            }
        }
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ongrounded)
        {
            averageRb.AddForce(transform.up * 100, ForceMode.Impulse);
            ongrounded = false;
        }
    }
}
