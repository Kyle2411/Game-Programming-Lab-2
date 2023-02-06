using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacke : MonoBehaviour
{
    public float my_Thrust = 500;
    public float pushForce = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, my_Thrust * Time.deltaTime);
    }

   
         private void OnCollisionEnter(Collision collision)
    {
        Vector3 pushDirection = collision.contacts[0].normal;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(-pushDirection * pushForce, ForceMode.Impulse);
    
    }
}