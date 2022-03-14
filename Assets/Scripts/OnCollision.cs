using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollsionEnter (Collision collision)
    {
        Debug.Log("Enter called.");
    }

    // Update is called once per frame
    void OnCollisionStay (Collision collision)
    {
        Debug.Log("Stay occuring..");
    }

    void OnCollisionExit (Collision collision)
    {
        Debug.Log("Exit called..");
    }
}
