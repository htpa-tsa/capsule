using UnityEngine;

public class hover : MonoBehaviour
{
    
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = false;
    }

}
