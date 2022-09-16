using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrintCreator : MonoBehaviour
{
    public GameObject footStepRight;
    public GameObject footStepLeft;
    private Animator animator;
    float time_right = 0;
    float time_left = 0;
    bool LeftFootPrinting;
    bool RightFootPrinting = true;
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

            //if (RightFootPrinting)
            //{
            //    this.time_right += Time.deltaTime;
            //    if (this.time_right > 0.6f)
            //    {
            //        this.time_right = 0;
            //        Instantiate(footStepRight, transform.position, transform.rotation);
            //        RightFootPrinting = false;
            //        LeftFootPrinting = true;
            //    }
            //}

            //if (LeftFootPrinting)
            //{
            //    this.time_left += Time.deltaTime;
            //    if (this.time_left > 0.6f)
            //    {
            //        this.time_left = 0;
            //        Instantiate(footStepLeft, transform.position, transform.rotation);
            //        LeftFootPrinting = false;
            //        RightFootPrinting = true;
            //    }
            //}


        }
        else
        {
            
            animator.SetBool("Walking", false);
            rb.velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -3, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, 0);
        }



        

    }

    void FootStepRight()
    {
        Debug.Log("FootStepRight");
        Instantiate(footStepRight, transform.position, transform.rotation);
    }

    void FootStepLeft()
    {
        Instantiate(footStepLeft, transform.position, transform.rotation);
    }
}
