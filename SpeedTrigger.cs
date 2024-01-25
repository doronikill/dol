using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float SpeedFactor = 2.5f;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= SpeedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= SpeedFactor;
    }
}
