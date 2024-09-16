using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnspeed = 0f;
    public float HorizontalInput;
    public float verticalInput;
   

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move the vehicle Forward
        //transform.Translate(0, 0, 1);


        transform.Translate(Vector3.forward * Time.deltaTime * speed*verticalInput);
        
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * HorizontalInput);
    }
}
