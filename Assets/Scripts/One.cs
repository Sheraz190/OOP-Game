using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class One : MonoBehaviour
{
    private Rigidbody playerRb;
    private bool isgrounded;
  
  
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        isgrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&isgrounded)
        {
            playerRb.AddForce(transform.up*100, ForceMode.Impulse);
            isgrounded = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.CompareTag("Ground"))
        {
            isgrounded = true;
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Spawn.Instance.isgameOver = true;
        }
    }




}
