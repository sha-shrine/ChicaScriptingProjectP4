using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    //start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position of my object
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //this if statement is going to chck the height of my object
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground");
        }
        else
        {
            Debug.Log("I am still in the air");
        }
    }
}