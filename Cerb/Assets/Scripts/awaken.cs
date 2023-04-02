using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awaken : MonoBehaviour
{
    private GameObject target;

    void Awake()
    {
        target = GameObject.FindWithTag("urs");
    }
}
