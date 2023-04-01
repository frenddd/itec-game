using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playercontroller : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float Speed = 40f;
    float horizontalMovement = 0f;
    bool jump = false;
    bool dash=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    



    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(horizontalMovement));
        horizontalMovement = Input.GetAxisRaw("Horizontal") * Speed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("jumping", true);
        }

        if (Input.GetButtonDown("Dash"))
        {
            dash = true;
        }
        if (Input.GetButtonUp("Dash"))
            dash = false;
    }

    //opreste animatia de sarit
    public void Landed()
    {
        animator.SetBool("jumping", false);
    }

    void FixedUpdate()
    {
        bool ok = false;
        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jump);
        jump = false;
        
        if (dash==true)
        {
            controller.Move(5 * horizontalMovement * Time.fixedDeltaTime, false, jump);
            ok = true;
        }
        else if (ok==true)
            controller.Move(horizontalMovement/5 * Time.fixedDeltaTime, false, jump);


    }
}