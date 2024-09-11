using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnspeed;
    private float horizontalInput;
    private float forwardlInput;
    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");

        //move the vehicle forward
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);

        //move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);

        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalInput);
        //rotate
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}
