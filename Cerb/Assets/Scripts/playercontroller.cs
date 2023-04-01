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
    float timer = 3f;
    bool ok = true;

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

    void cooldown()
    {
        if (timer > 0)
        {
            Debug.Log(timer);
            timer -= Time.fixedDeltaTime;
        }
        else
            if (timer <= 0)
        {
            controller.Move(horizontalMovement / 5 * Time.fixedDeltaTime, false, jump);
            dash = false;
            timer = 0;
            ok = false;
        }
        
    }

    void coolup()
    {   //se reincarca ablitatea
        if (timer <= 3)
        {
            Debug.Log(timer);
            timer += Time.fixedDeltaTime;
        }

        

        if( timer >= 3)
        { 
            timer = 3;
            ok = true;
        }
        
    }

    void FixedUpdate()
    {
        
        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jump);
        jump = false;
        
        if (dash==true && ok==true)
        {
            controller.Move(5 * horizontalMovement * Time.fixedDeltaTime, false, jump);
            cooldown();
        }
        
        if(ok==false)
        {
            coolup();
        }
    }
}