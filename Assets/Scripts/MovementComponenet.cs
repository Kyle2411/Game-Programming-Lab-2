using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponenet : MonoBehaviour
{

    public Rigidbody my_Rigidbody;
    public float my_Thrust = 4f;
   
    // Start is called before the first frame update
    void Start()
    {
        my_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      

      Vector3 move = new Vector3(-Input.GetAxis("Vertical"), 0.0f, Input.GetAxis("Horizontal"));
      my_Rigidbody.AddForce(move * my_Thrust);

     
    }
}
