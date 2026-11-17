using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;

    private int staplers;
    private int sellotape;


    public void FruitMachine(int a, int b)
    {
       int answer;
        answer = a + b;
        Debug.Log("Fruit total is: " + answer);
    }


    private void OfficeMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office supplies total is: " + answer);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
