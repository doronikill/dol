using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Destroy(gameObject, 33);
    }

     void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("TurtleShell"))
    //    {
    //        Destroy(other.gameObject);
    //        Destroy(gameObject);
    //    }
    //}
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag. == "TurtleShell")
        {
            Destroy(other.gameObject);  
        }
    }*/

     void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
