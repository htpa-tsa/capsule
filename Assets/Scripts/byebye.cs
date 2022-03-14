using UnityEngine;

public class byebye : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(0, 40, 4000 * Time.deltaTime);
        rb.useGravity = true;
    }
}
