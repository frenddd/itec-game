using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptchase : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject OBJECT1;
    public GameObject urs;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        
            if (gameObject.tag == "bear")
                OBJECT1.SetActive(false);

           
        
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
