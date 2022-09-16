using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrintCreator : MonoBehaviour
{
    public GameObject footStepRight;
    public GameObject footStepLeft;
    private Animator animator;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, 5);
            gameObject.transform.position += velocity * Time.deltaTime;
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
            rb.velocity = Vector3.zero;
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -6, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 6, 0);
        }


    }

    void FootStepRight()
    {
        Instantiate(footStepRight, transform.position, transform.rotation);
        Laser_Create_Player.instance.PlayerLaserCreate();
    }

    void FootStepLeft()
    {
        Instantiate(footStepLeft, transform.position, transform.rotation);
        Laser_Create_Player.instance.PlayerLaserCreate();
    }
}
