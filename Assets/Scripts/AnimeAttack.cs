using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeAttack : MonoBehaviour
{
    //Variables;
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
         anim.SetBool("Attacking",true);
         else if (Input.GetButtonUp("Fire1"))
         anim.SetBool("Attacking",false);
    }
public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    #region Monobehaviour API

    private void update () {
        rb = GetComponent<Rigidbody>();
	}

	private void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    #endregion
}
}