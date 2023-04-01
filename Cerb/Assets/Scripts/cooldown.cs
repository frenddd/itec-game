using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cooldown : MonoBehaviour
{
    public float time=3;
    private float timeout=0;

    private void Update()
    {
        if (Time.time > time) { 
        if(Input.GetButtonDown("dash"))
        {
            timeout = Time.time + time;
                Debug.Log("nu se mai poate");
        }
        }
    }
}
