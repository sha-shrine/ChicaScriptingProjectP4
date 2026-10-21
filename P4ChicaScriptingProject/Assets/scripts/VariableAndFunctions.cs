using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAndFunctions : MonoBehaviour
{

    // this is variable
    int myInt = 5;
    void Start()
    {
        Debug.Log(myInt);
       myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }


    int MultiplyByTwo(int number)
    {
        int results;
        results = number * 2;
        return results;
    }
}