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
        }


    }

    void FixedUpdate()
    {
        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
