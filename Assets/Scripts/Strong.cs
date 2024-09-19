using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strong :MonoBehaviour
{
    private Rigidbody strongRb;
    private bool ingrounded;
    
    // Start is called before the first frame update
    void Start()
    {
        strongRb = GetComponent<Rigidbody>();
        ingrounded = true;
      
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
            ingrounded = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Spawn.Instance.health -= 2;
            Debug.Log("Health Decreases");
            {
                if (Spawn.Instance.health == 0)
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
        if (Input.GetKeyDown(KeyCode.Space) && ingrounded)
        {
            strongRb.AddForce(transform.up * 10, ForceMode.Impulse);
            ingrounded = false;
        }
    }


}
