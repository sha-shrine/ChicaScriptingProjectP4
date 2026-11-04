using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    //Creating the variable for my script


    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f; 
    }

    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            Debug.Log("Coffee is too hot");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            Debug.Log("Coffee is too cold");
        }
        else
        {
            Debug.Log("Coffee is just right");
        }
    }
}